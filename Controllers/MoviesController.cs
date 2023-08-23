using CinemaTicket.DB;
using CinemaTicket.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CinemaTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public MoviesController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // GET: api/movies
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            return _applicationDbContext.Movies;
        }

        // POST: api/movies
        [HttpPost]
        public ActionResult<Movie> AddMovie(Movie movie)
        {
            _applicationDbContext.Movies.Add(movie);
            _applicationDbContext.SaveChanges();

            return CreatedAtAction(nameof(GetMovies), new { id = movie.Id }, movie);
        }

        // PUT: api/movies/{id}
        [HttpPut("{id}")]
        public ActionResult<Movie> UpdateMovie(int id, Movie movie)
        {
            var existingMovie = _applicationDbContext.Movies.FirstOrDefault(m => m.Id == id);
            if (existingMovie == null)
            {
                return NotFound();
            }

            existingMovie.Title = movie.Title;
            existingMovie.Description = movie.Description;
            existingMovie.Genre = movie.Genre;

            _applicationDbContext.Movies.Update(existingMovie);
            _applicationDbContext.SaveChanges();

            return existingMovie;
        }

        // DELETE: api/movies/{id}
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteMovie(int id)
        {
            var movieToDelete = _applicationDbContext.Movies.FirstOrDefault(m => m.Id == id);
            if (movieToDelete == null)
            {
                return false;
            }

            _applicationDbContext.Movies.Remove(movieToDelete);
            _applicationDbContext.SaveChanges();
            return true;
        }
    }
}

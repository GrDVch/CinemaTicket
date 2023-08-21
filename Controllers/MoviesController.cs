using CinemaTicket.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Movie 1", Description = "Description 1", Duration = TimeSpan.FromMinutes(120), Genre = "Action" },
            new Movie { Id = 2, Title = "Movie 2", Description = "Description 2", Duration = TimeSpan.FromMinutes(110), Genre = "Drama" },
            new Movie { Id = 3, Title = "Movie 3", Description = "Description 3", Duration = TimeSpan.FromMinutes(105), Genre = "Comedy" }
        };

        // GET: api/movies
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            return _movies;
        }

        // POST: api/movies
        [HttpPost]
        public ActionResult<Movie> AddMovie(Movie movie)
        {
            movie.Id = _movies.Count + 1;
            _movies.Add(movie);
            return CreatedAtAction(nameof(GetMovies), new { id = movie.Id }, movie);
        }

        // PUT: api/movies/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, Movie movie)
        {
            var existingMovie = _movies.FirstOrDefault(m => m.Id == id);
            if (existingMovie == null)
            {
                return NotFound();
            }

            existingMovie.Title = movie.Title;
            existingMovie.Description = movie.Description;
            existingMovie.Duration = movie.Duration;
            existingMovie.Genre = movie.Genre;

            return NoContent();
        }

        // DELETE: api/movies/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            var movieToDelete = _movies.FirstOrDefault(m => m.Id == id);
            if (movieToDelete == null)
            {
                return NotFound();
            }

            _movies.Remove(movieToDelete);
            return NoContent();
        }
    }
}

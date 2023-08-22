using CinemaTicket.DB;
using CinemaTicket.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {


        // GET: api/movies
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            return CinemaTicketDB.Movies;
        }

        // POST: api/movies
        [HttpPost]
        public ActionResult<Movie> AddMovie(Movie movie)
        {
            movie.Id = CinemaTicketDB.Movies.Count + 1;
            CinemaTicketDB.Movies.Add(movie);
            return CreatedAtAction(nameof(GetMovies), new { id = movie.Id }, movie);
        }

        // PUT: api/movies/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, Movie movie)
        {
            var existingMovie = CinemaTicketDB.Movies.FirstOrDefault(m => m.Id == id);
            if (existingMovie == null)
            {
                return NotFound();
            }

            existingMovie.Title = movie.Title;
            existingMovie.Description = movie.Description;
            existingMovie.Genre = movie.Genre;

            return NoContent();
        }

        // DELETE: api/movies/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            var movieToDelete = CinemaTicketDB.Movies.FirstOrDefault(m => m.Id == id);
            if (movieToDelete == null)
            {
                return NotFound();
            }

            CinemaTicketDB.Movies.Remove(movieToDelete);
            return NoContent();
        }
    }
}

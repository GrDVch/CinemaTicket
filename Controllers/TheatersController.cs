using CinemaTicket.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatersController : ControllerBase
    {
        private static List<Theater> _theaters = new List<Theater>
        {
            new Theater { Id = 1, Name = "Theater A", Location = "Location A", Showtimes = _showtimes},
            new Theater { Id = 2, Name = "Theater B", Location = "Location B", Showtimes = _showtimes }
        };
        private static List<Showtime> _showtimes = new List<Showtime>
        {
            new Showtime { Id = 1, DateTime = DateTime.Now, MovieId = 1 },
            new Showtime { Id = 2, DateTime = DateTime.Now, MovieId = 2 },
        };

        public TheatersController() 
        {
        } 

        // GET: api/theaters
        [HttpGet]
        public ActionResult<IEnumerable<Theater>> GetTheaters()
        {
            return _theaters;
        }

        // POST: api/theaters
        [HttpPost]
        public ActionResult<Theater> AddTheater(Theater theater)
        {
            theater.Id = _theaters.Count + 1;
            _theaters.Add(theater);
            return CreatedAtAction(nameof(GetTheaters), new { id = theater.Id }, theater);
        }

        // POST: api/theaters/{theaterId}/showtimes
        [HttpPost("{theaterId}/showtimes")]
        public ActionResult AddShowtime(int theaterId, Showtime showtime)
        {
            var theater = _theaters.FirstOrDefault(t => t.Id == theaterId);
            if (theater != null)
            {
                showtime.Id = theater.Showtimes.Count + 1;
                theater.Showtimes.Add(showtime);
            }
            return new EmptyResult();
        }
    }
}

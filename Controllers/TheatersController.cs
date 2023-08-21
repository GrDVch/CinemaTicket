using CinemaTicket.DB;
using CinemaTicket.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatersController : ControllerBase
    {

        public TheatersController() 
        {
        } 

        // GET: api/theaters
        [HttpGet]
        public ActionResult<IEnumerable<Theater>> GetTheaters()
        {
            return CinemaTicketDB.Theaters;
        }

        // POST: api/theaters
        [HttpPost]
        public ActionResult<Theater> AddTheater(Theater theater)
        {
            theater.Id = CinemaTicketDB.Theaters.Count + 1;
            CinemaTicketDB.Theaters.Add(theater);
            return CreatedAtAction(nameof(GetTheaters), new { id = theater.Id }, theater);
        }

        // POST: api/theaters/{theaterId}/showtimes
        [HttpPost("{theaterId}/showtimes")]
        public ActionResult AddShowtime(int theaterId, Showtime showtime)
        {
            var theater = CinemaTicketDB.Theaters.FirstOrDefault(t => t.Id == theaterId);
            if (theater != null)
            {
                showtime.Id = theater.Showtimes.Count + 1;
                theater.Showtimes.Add(showtime);
            }
            return new EmptyResult();
        }
    }
}

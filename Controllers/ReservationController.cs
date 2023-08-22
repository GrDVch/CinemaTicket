using CinemaTicket.DB;
using CinemaTicket.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : Controller
    {
        // POST: api/reserve-seats
        [HttpPost("reserve-seats")]
        public ActionResult<Reservation> ReserveSeats(Reservation reservation)
        {
            var theater = CinemaTicketDB.Theaters.FirstOrDefault(t => t.Id == reservation.TheaterId);
            if (theater == null)
            {
                return NotFound("Theater not found.");
            }

            var showtime = theater.Showtimes.FirstOrDefault(s => s.Id == reservation.ShowtimeId);
            if (showtime == null)
            {
                return NotFound("Showtime not found.");
            }

            var seat = showtime.Seats.FirstOrDefault(s => s.Id == reservation.SeatId);
            if (showtime == null)
            {
                return NotFound("seat not found.");
            }

            var isReserved = CinemaTicketDB.Reservations.Any(r => 
            r.ShowtimeId == reservation.ShowtimeId
            && r.TheaterId == reservation.TheaterId 
            && r.SeatId == reservation.SeatId
            && r.ExpiryTime > DateTime.Now
            );
            if (isReserved)
            {
                return BadRequest("Place reserved");
            }

            reservation.Id = CinemaTicketDB.Reservations.Count + 1;
            reservation.ExpiryTime = DateTime.Now.AddMinutes(15);
            CinemaTicketDB.Reservations.Add(reservation);

            return reservation;
        }

    }
}

using CinemaTicket.DB;
using CinemaTicket.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : Controller
    {
        //private static List<Reservation> _reservations = new List<Reservation>();


        //// POST: api/theaters/{theaterId}/showtimes/{showtimeId}/reserve
        //[HttpPost("{theaterId}/showtimes/{showtimeId}/reserve")]
        //public ActionResult<Reservation> ReserveSeats(int theaterId, int showtimeId, [FromBody] List<int> seatNumbers, [FromQuery] int userId)
        //{
        //    var theater = CinemaTicketDB.Theaters.FirstOrDefault(t => t.Id == theaterId);
        //    if (theater == null)
        //    {
        //        return NotFound("Theater not found.");
        //    }

        //    var showtime = theater.Showtimes.FirstOrDefault(s => s.Id == showtimeId);
        //    if (showtime == null)
        //    {
        //        return NotFound("Showtime not found.");
        //    }

        //    var user = CinemaTicketDB.Users.FirstOrDefault(u => u.Id == userId);
        //    if (user == null)
        //    {
        //        return NotFound("User not found.");
        //    }

        //    if (seatNumbers.Any(seatNumber => !IsSeatAvailable(showtime, seatNumber)))
        //    {
        //        return BadRequest("One or more seats are already reserved or unavailable.");
        //    }

        //    var reservation = new Reservation
        //    {
        //        Id = _reservations.Count + 1,
        //        ShowtimeId = showtimeId,
        //        UserId = userId,
        //        ReservedSeats = seatNumbers,
        //        ExpiryTime = DateTime.Now.AddMinutes(15) // Set reservation timeout to 15 minutes
        //    };

        //    _reservations.Add(reservation);

        //    foreach (var seatNumber in seatNumbers)
        //    {
        //        showtime.AvailableSeats--;
        //        showtime.ReservedSeats.Add(seatNumber);
        //    }

        //    return CreatedAtAction(nameof(GetReservation), new { reservationId = reservation.Id }, reservation);
        //}

        //private bool IsSeatAvailable(Showtime showtime, int seatNumber)
        //{
        //    return !showtime.ReservedSeats.Contains(seatNumber);
        //}

        //// Implement a timer mechanism to periodically check and release unconfirmed reservations
        //private void ReleaseExpiredReservations()
        //{
        //    var currentTime = DateTime.Now;
        //    var expiredReservations = _reservations.Where(r => r.ExpiryTime <= currentTime).ToList();

        //    foreach (var reservation in expiredReservations)
        //    {
        //        var showtime = CinemaTicketDB.Theaters.SelectMany(t => t.Showtimes).FirstOrDefault(s => s.Id == reservation.ShowtimeId);
        //        if (showtime != null)
        //        {
        //            foreach (var seatNumber in reservation.ReservedSeats)
        //            {
        //                showtime.AvailableSeats++;
        //                showtime.ReservedSeats.Remove(seatNumber);
        //            }
        //        }

        //        _reservations.Remove(reservation);
        //    }
        //}
    }
}

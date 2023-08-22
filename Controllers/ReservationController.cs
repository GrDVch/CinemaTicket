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

            if (seat.IsPaid)
            {
                return NotFound("Seat Is Paid.");
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

        [HttpPost("payment")]
        public ActionResult<BookingDetails> Payment(int userId)
        {
            var seatIds = CinemaTicketDB.Reservations.Where(r => r.UserId == userId)?.Select(x => x.SeatId);
            if (seatIds == null || !seatIds.Any())
            {
                return NotFound("No reservation.");
            }

            var seats = CinemaTicketDB.Theaters.SelectMany(x => x.Showtimes).SelectMany(x => x.Seats);
            var bookingDetails = new BookingDetails();
            foreach (var seat in seats)
            {
                if (seatIds.Contains(seat.Id))
                {
                    seat.IsPaid = true;
                    bookingDetails.Details.Add(new BookingDetail() 
                    {
                    Price = seat.Price,
                    Seat = seat,
                    });
                    bookingDetails.Price += bookingDetails.Price + seat.Price;
                }
            }

            return bookingDetails;
        }

    }
}

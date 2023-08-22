using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaTicket.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public int ShowtimeId { get; set; }
        public int SeatId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("TheaterId")]
        public virtual Theater Theater { get; set; }
        public virtual Showtime Showtime { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual User User { get; set; }
        public virtual DateTime ExpiryTime { get; set; }
    }
}

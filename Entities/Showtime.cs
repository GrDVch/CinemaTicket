namespace CinemaTicket.Entities
{
    public class Showtime
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int TheaterId { get; set; }
        public virtual Theater Theater { get; set; }
        public virtual Movie Movie { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<Seat> Seats { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}

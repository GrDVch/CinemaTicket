namespace CinemaTicket.Entities
{
    public class Theater
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Showtime> Showtimes { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}

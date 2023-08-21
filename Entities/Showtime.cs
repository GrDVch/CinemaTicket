namespace CinemaTicket.Entities
{
    public class Showtime
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public DateTime DateTime { get; set; }
    }
}

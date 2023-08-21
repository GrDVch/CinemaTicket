namespace CinemaTicket.Entities
{
    public class Theater
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Showtime> Showtimes { get; set; } = new List<Showtime>();
    }
}

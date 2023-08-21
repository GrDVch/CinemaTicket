namespace CinemaTicket.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ShowtimeId { get; set; }
        public int UserId { get; set; }
        public List<int> ReservedSeats { get; set; } = new List<int>();
        public DateTime ExpiryTime { get; set; }
    }
}

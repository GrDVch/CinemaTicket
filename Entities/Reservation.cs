namespace CinemaTicket.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int TheaterId { get; set; }
        public int ShowtimeId { get; set; }
        public int SeatId { get; set; }
        public int UserId { get; set; }
        public DateTime ExpiryTime { get; set; }
    }
}

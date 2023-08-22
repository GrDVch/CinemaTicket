namespace CinemaTicket.Entities
{
    public class Seat
    {
        public int Id { get; set; }
        public int Row { get; set; }
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }
        public bool IsPaid { get; set; }
    }
}

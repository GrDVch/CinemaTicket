namespace CinemaTicket.Entities
{
    public class BookingDetail
    {
        public Seat Seat { get; set; }
        public decimal Price { get; set; }
    }

    public class BookingDetails
    {
        public List<BookingDetail> Details { get; set; } = new List<BookingDetail>();
        public decimal Price { get; set; }
    }
}

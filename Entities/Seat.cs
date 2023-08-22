using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaTicket.Entities
{
    public class Seat
    {
        public int Id { get; set; }
        public int Row { get; set; }
        public int SeatNumber { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public bool IsPaid { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}

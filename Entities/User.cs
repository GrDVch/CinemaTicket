﻿namespace CinemaTicket.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}

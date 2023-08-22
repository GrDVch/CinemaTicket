using CinemaTicket.Entities;

namespace CinemaTicket.DB
{
    public static class CinemaTicketDB
    {
        public static List<Movie> Movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Movie 1", Description = "Description 1", Genre = "Action" },
            new Movie { Id = 2, Title = "Movie 2", Description = "Description 2", Genre = "Drama" },
            new Movie { Id = 3, Title = "Movie 3", Description = "Description 3", Genre = "Comedy" }
        };
        public static List<User> Users = new List<User>
    {
        new User { Id = 1, Username = "user1" },
        new User { Id = 2, Username = "user2" }
    };
        public static List<Theater> Theaters = new List<Theater>
        {
            new Theater { Id = 1, Name = "Theater A", Location = "Location A", Showtimes = new List<Showtime>
        {
            new Showtime { Id = 1, DateTime= DateTime.Now, TheaterId = 1, MovieId= 1, Seats = new List<Seat>
        {
            new Seat { Id = 1, Row = 1, SeatNumber = 1, Price = 12.3m   },
            new Seat { Id = 2, Row = 1, SeatNumber = 2, Price = 12.3m   },
            new Seat { Id = 3, Row = 2, SeatNumber = 1, Price = 12.3m   },
            new Seat { Id = 4, Row = 2, SeatNumber = 2, Price = 12.3m   },
        }   },
            new Showtime { Id = 2, DateTime= DateTime.Now, TheaterId = 1, MovieId= 2, Seats = new List<Seat>
        {
            new Seat { Id = 5, Row = 1, SeatNumber = 1, Price = 14.4m   },
            new Seat { Id = 6, Row = 1, SeatNumber = 2, Price = 14.4m   },
            new Seat { Id = 7, Row = 2, SeatNumber = 1, Price = 14.4m   },
            new Seat { Id = 8, Row = 2, SeatNumber = 2, Price = 14.4m   },
        }   },
        }},
            new Theater { Id = 2, Name = "Theater B", Location = "Location B", Showtimes = new List<Showtime>
        {
            new Showtime { Id = 3, DateTime= DateTime.Now, TheaterId = 2, MovieId= 1, Seats = new List<Seat>
        {
            new Seat { Id = 9, Row = 1, SeatNumber = 1, Price = 15.5m   },
            new Seat { Id = 10, Row = 1, SeatNumber = 2, Price = 15.5m   },
            new Seat { Id = 11, Row = 2, SeatNumber = 1, Price = 15.5m   },
            new Seat { Id = 12, Row = 2, SeatNumber = 2, Price = 15.5m   },
            new Seat { Id = 13, Row = 3, SeatNumber = 1, Price = 15.5m   },
            new Seat { Id = 14, Row = 3, SeatNumber = 2, Price = 15.5m   },
        }   },
            new Showtime { Id = 4, DateTime= DateTime.Now, TheaterId = 2, MovieId= 2, Seats = new List<Seat>
        {
            new Seat { Id = 15, Row = 1, SeatNumber = 1, Price = 16.6m   },
            new Seat { Id = 16, Row = 1, SeatNumber = 2, Price = 16.6m   },
            new Seat { Id = 17, Row = 2, SeatNumber = 1, Price = 16.6m   },
            new Seat { Id = 18, Row = 2, SeatNumber = 2, Price = 16.6m   },
            new Seat { Id = 19, Row = 3, SeatNumber = 1, Price = 16.6m   },
            new Seat { Id = 20, Row = 3, SeatNumber = 2, Price = 16.6m   },
        }   },
        } },
        };

        public static List<Reservation> Reservations = new List<Reservation>
        {
            new Reservation { Id = 1, TheaterId = 2, ShowtimeId = 1, SeatId = 5, ExpiryTime = DateTime.Now, UserId = 1  },
            
        };
    }
}

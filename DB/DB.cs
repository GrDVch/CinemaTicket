using CinemaTicket.Entities;

namespace CinemaTicket.DB
{
    public static class CinemaTicketDB
    {
        public static List<Movie> Movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Movie 1", Description = "Description 1", Duration = TimeSpan.FromMinutes(120), Genre = "Action" },
            new Movie { Id = 2, Title = "Movie 2", Description = "Description 2", Duration = TimeSpan.FromMinutes(110), Genre = "Drama" },
            new Movie { Id = 3, Title = "Movie 3", Description = "Description 3", Duration = TimeSpan.FromMinutes(105), Genre = "Comedy" }
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
            new Showtime { Id = 1, DateTime = DateTime.Now, MovieId = 1 },
            new Showtime { Id = 2, DateTime = DateTime.Now, MovieId = 2 },
        }},
            new Theater { Id = 2, Name = "Theater B", Location = "Location B", Showtimes = new List<Showtime>
        {
            new Showtime { Id = 1, DateTime = DateTime.Now, MovieId = 1 },
            new Showtime { Id = 2, DateTime = DateTime.Now, MovieId = 2 },
        } }
        };
    }
}

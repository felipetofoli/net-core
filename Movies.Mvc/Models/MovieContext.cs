using Microsoft.EntityFrameworkCore;

namespace Movies.Mvc.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movies.Mvc.Models.Movie> Movie { get; set; }
    }
}
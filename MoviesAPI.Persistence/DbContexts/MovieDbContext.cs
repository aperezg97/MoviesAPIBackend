using Microsoft.EntityFrameworkCore;

using MoviesAPI.Models;

namespace MoviesAPI.Persistence.DbContexts
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        public MovieDbContext()
        {
        }

        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }
    }
}

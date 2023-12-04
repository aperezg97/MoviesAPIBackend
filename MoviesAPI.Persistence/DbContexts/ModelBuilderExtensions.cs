using Microsoft.EntityFrameworkCore;

using MoviesAPI.Models;
using MoviesAPI.Models.Models;

namespace MoviesAPI.Persistence.DbContexts
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(SeedData.Movies);
            modelBuilder.Entity<Category>().HasData(SeedData.Categories);
            modelBuilder.Entity<MovieCategory>().HasData(SeedData.MovieCategories);
        }
    }
}

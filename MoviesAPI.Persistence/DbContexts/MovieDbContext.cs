using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

using Microsoft.EntityFrameworkCore;

using MoviesAPI.Models;
using MoviesAPI.Models.Models;
using MoviesAPI.Persistence.DbContexts;

namespace MoviesAPI.Persistence.DbContexts
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }

        public MovieDbContext()
        {
        }

        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasMany(e => e.Categories).WithMany(e => e.Movies).UsingEntity<MovieCategory>();

            modelBuilder.Entity<Movie>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Category>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<MovieCategory>().Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Movie>().Property(b => b.InsertDate).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            modelBuilder.Entity<Movie>().Property(b => b.UpdateDate).ValueGeneratedOnUpdate();

            modelBuilder.Entity<Category>().Property(b => b.InsertDate).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            modelBuilder.Entity<Category>().Property(b => b.UpdateDate).ValueGeneratedOnUpdate();

            modelBuilder.Entity<MovieCategory>().Property(b => b.InsertDate).HasDefaultValueSql("getdate()").ValueGeneratedOnAdd();
            modelBuilder.Entity<MovieCategory>().Property(b => b.UpdateDate).ValueGeneratedOnUpdate();

            modelBuilder.Seed();
        }
    }
}

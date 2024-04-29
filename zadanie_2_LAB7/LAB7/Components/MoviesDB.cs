
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace LAB7.Components
{
    public class MoviesDB : DbContext
    {
        public DbSet<Movie> DataMovie { get; set; }
        public DbSet<Rating> DataRating { get; set; }

        public MoviesDB() {

            Database.EnsureCreated();
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@" Data Source = C:\Users\Dawid\source\repos\.NET\zadanie_2\LAB7\Data\Baza.db");
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(e => e.Ratings)
                .WithOne(e => e.Movie)
                .HasForeignKey(e => e.MovieId)
                .IsRequired();
        }


    }
}

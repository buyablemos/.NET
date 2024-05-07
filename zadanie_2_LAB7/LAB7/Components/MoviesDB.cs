
using Microsoft.EntityFrameworkCore;

namespace LAB7.Components
{
    public class MoviesDB : DbContext
    {
        public DbSet<Movie> DataMovie { get; set; }
        public DbSet<Rating> DataRating { get; set; }

        public MoviesDB(DbContextOptions<MoviesDB> options) : base(options)
        {
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
        */
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

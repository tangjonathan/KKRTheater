using Microsoft.EntityFrameworkCore;
using TheaterData.Entities;


namespace TheaterData
{
    public class TheaterContext : DbContext
    {

        public TheaterContext(DbContextOptions options) : base(options) {}

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Director> Directors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmCast>()
            .HasKey(x => new { x.ActorId, x.MovieId });

            modelBuilder.Entity<MovieGenre>()
            .HasKey(x => new { x.MovieId, x.GenreId });


            base.OnModelCreating(modelBuilder);
        }
    }
}


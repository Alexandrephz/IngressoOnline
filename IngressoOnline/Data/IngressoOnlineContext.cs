using IngressoOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace IngressoOnline.Data
{
    public class IngressoOnlineContext : DbContext
    {
        public IngressoOnlineContext(DbContextOptions<IngressoOnlineContext> options)
        : base(options)
        {
        }
        public DbSet<Movie> movies { get; set; } = default!;
        public DbSet<Actor> actors { get; set; } = default!;
        public DbSet<Director> directors { get; set; } = default!;
        public DbSet<MovieCategory> movieCategories { get; set; } = default!;
        public DbSet<MovieRating> movieRatings { get; set; } = default!;
        public DbSet<Publisher> publishers { get; set; } = default!;
        public DbSet<ActorMovie> actorMovies { get; set; } = default!;
        public DbSet<DirectorMovie> directorMovies { get; set; } = default!;
        public DbSet<PublisherMovie> publisherMovies { get; set; } = default!;
    }
}

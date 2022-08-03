using Antra.MoviesCRM.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Infrastructure.Data
{
    public class MovieCrmDbContext: DbContext
    {
        public MovieCrmDbContext(DbContextOptions<MovieCrmDbContext> options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        { 
            builder.Entity<MovieCrew>()
                .HasKey(nameof(MovieCrew.MovieId), nameof(MovieCrew.CrewId),
                nameof(MovieCrew.Department), nameof(MovieCrew.Job));
            builder.Entity<MovieCast>()
                .HasKey(nameof(MovieCast.MovieId), nameof(MovieCast.CastId),
                nameof(MovieCast.Character));
            builder.Entity<MovieGenre>()
                .HasKey(nameof(MovieGenre.MovieId), nameof(MovieGenre.GenreId));
            builder.Entity<Review>()
                .HasKey(nameof(Review.MovieId), nameof(Review.UserId));
        }

        public DbSet<Cast> Casts { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<MovieCrew> MovieCrews { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<User> Users { get; set; }

    }


}

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
        public DbSet<Crew> Crew { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<MovieCrew> MovieCrew { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
    }


}

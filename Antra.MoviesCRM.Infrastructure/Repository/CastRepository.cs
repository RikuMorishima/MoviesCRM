using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Antra.MoviesCRM.Infrastructure.Repository
{
    public class CastRepository : BaseRepositoryAsync<Cast>, ICastRepository
    {
        public CastRepository(MovieCrmDbContext _context) : base(_context)
        {

        }

        public override async Task<Cast> GetByIdAsync(int id)
        {
            var cast = await db.Set<Cast>().FindAsync(id);
            if (cast == null) 
                return null;

            await db.Set<MovieCast>().Where(x => x.CastId == id).ForEachAsync(
                async delegate(MovieCast mc)
                {
                    _ = cast.Movies.Append(await db.Set<Movie>().FindAsync(mc.MovieId));
                });
            return cast;
        }

    }
}

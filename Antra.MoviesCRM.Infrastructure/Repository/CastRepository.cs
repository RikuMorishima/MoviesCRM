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
        public IEnumerable<IMovieService> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task<Cast> GetByIdAsync(int id)
        {
            return await db.Set<MovieCrew>().Where(x => x.MovieId == id).ToListAsync();
        }
    }
}

using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;

namespace Antra.MoviesCRM.Infrastructure.Repository
{
    public class CastRepository : ICastRepository
    {
        public IEnumerable<IMovieService> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

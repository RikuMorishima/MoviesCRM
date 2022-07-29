using Antra.MoviesCRM.Core.Contracts.Services;

namespace Antra.MoviesCRM.Core.Contracts.Repository
{
    public interface ICastRepository
    {
        IEnumerable<IMovieService> GetById(int id);
    }
}

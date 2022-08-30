using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;

namespace Antra.MoviesCRM.Core.Contracts.Repository
{
    public interface ICastRepository: IRepositoryAsync<Cast>
    {
        //public Task<CastModel> GetByIdAsync(int id);
        public Task<int> AddToMovie(int movieId, int castId, string character);
    }
}

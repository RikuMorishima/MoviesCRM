using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;

namespace Antra.MoviesCRM.Core.Contracts.Services
{
    public interface ICastService
    {
        Task<CastModel> GetCastDetails(int id);
        Task<int> AddCast(CastModel model);
        Task<int> PutCast(CastModel model);
        Task<IEnumerable<CastModel>> GetAllCasts();
        Task<CastModel> GetCastById(int castId);
        Task<int> BindMovieCast(MovieCastModel model);
    }
}

using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;

namespace Antra.MoviesCRM.Core.Contracts.Services
{
    public interface ICastService
    {
        Task<CastModel> GetCastDetails(int id);
    }
}

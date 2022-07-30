using Antra.MoviesCRM.Core.Entities;

namespace Antra.MoviesCRM.Core.Contracts.Services
{
    public interface ICastService
    {
        Task<Cast> GetCastDetails(int id);
    }
}

using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Antra.MoviesCRM.Infrastructure.Repository;

namespace Antra.MoviesCRM.Infrastructure.Services
{
    public class CastService : ICastService
    {
        ICastRepository castRepository;

        public CastService(ICastRepository castRepository)
        {
            this.castRepository = castRepository;
        }

        public async Task<CastModel> GetCastDetails(int castId)
        {
            var castDetails = await castRepository.GetByIdAsync(castId);
            return castDetails;
        }
    }
}

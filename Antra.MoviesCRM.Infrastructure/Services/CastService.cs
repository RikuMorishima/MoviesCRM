using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;

namespace Antra.MoviesCRM.Infrastructure.Services
{
    public class CastService : ICastService
    {
        ICastRepository castRepository;
        IMovieRepository movieRepository;
        public CastService(ICastRepository castRepository,IMovieRepository movieRepository)
        {
            this.castRepository = castRepository;
            this.movieRepository = movieRepository;
        }

        public async Task<Cast> GetCastDetails(int castId)
        {
            var castDetails = await castRepository.GetByIdAsync(castId);
            /*CastModel model = new CastModel()
            {
                Id = castDetails.Id,
                Name = castDetails.Name,
                Gender = castDetails.Gender,
                ProfilePath = castDetails.ProfilePath,
                TmdbUrl = castDetails.TmdbUrl,
                Movies = castDetails.Movies
            };*/

            return castDetails;
        }
    }
}

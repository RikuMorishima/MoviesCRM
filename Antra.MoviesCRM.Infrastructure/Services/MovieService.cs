using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Models;
using Antra.MoviesCRM.Infrastructure.Repository;

namespace Antra.MoviesCRM.Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        IMovieRepository movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;

        }

        public IEnumerable<MovieModel> GetMoviesByGenre(int genreId, int pageSize, int pageNumber)
        {
            //return await ((MovieRepository)movieRepository).GetByIdAsync(castId);
            throw new NotImplementedException();
        }
    }
}

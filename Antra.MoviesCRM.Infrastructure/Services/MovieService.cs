using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Models;
using Antra.MoviesCRM.Infrastructure.Repository;

namespace Antra.MoviesCRM.Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        readonly IMovieRepository movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;

        }

        public async Task<PaginationModel<IEnumerable<MovieModel>>> GetMoviesByGenre(int genreId, int pageSize, int pageNum)
        {
         
            int totalPages = (int) Math.Ceiling((double) movieRepository.GetCount() /pageSize);

            var page = await movieRepository.GetAllByGenreIdPaginatedAsync(genreId, pageSize, pageNum);
            PaginationModel< IEnumerable < MovieModel> > model = new() 
            { 
                Value = page, 
                PageIndex=pageNum, 
                PageSize=pageSize,
                PageCount=totalPages,
            };

            return model;
        }
    }
}

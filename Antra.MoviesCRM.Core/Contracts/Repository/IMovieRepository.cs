using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;

namespace Antra.MoviesCRM.Core.Contracts.Repository
{
    public interface IMovieRepository : IRepositoryAsync<Movie>
    {
        public Task<IEnumerable<MovieModel>> GetAllByGenreIdPaginatedAsync(int genreId, int pageSize, int pageNum);
    }
}

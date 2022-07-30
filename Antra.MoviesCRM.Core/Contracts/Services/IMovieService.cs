using Antra.MoviesCRM.Core.Models;

namespace Antra.MoviesCRM.Core.Contracts.Services
{
    public interface IMovieService
    {
        public Task<PaginationModel<IEnumerable<MovieModel>>> GetMoviesByGenre(int genreId, int pageSize, int pageNum);
    }
}

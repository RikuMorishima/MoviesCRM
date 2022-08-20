using Antra.MoviesCRM.Core.Models;

namespace Antra.MoviesCRM.Core.Contracts.Services
{
    public interface IMovieService: IServiceBase<MovieModel>
    {
        public Task<PaginationModel<IEnumerable<MovieModel>>> GetMoviesByGenre(int genreId, int pageSize=30, int pageNum=1);
    }
}

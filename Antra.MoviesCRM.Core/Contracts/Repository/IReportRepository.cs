using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;

namespace Antra.MoviesCRM.Core.Contracts.Repository
{
    public interface IReportRepository //Report what?
    {
        Task<IEnumerable<MoviesReportModel>> GetTopPurchasedMovies(DateTime? fromDate, DateTime? toDate, int pageSize, int pageIndex);
    }
}

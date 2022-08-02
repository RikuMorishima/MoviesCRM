using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Models;

namespace Antra.MoviesCRM.Infrastructure.Repository
{
    public class ReportRepository : IReportRepository
    {
        public Task<IEnumerable<MoviesReportModel>> GetTopPurchasedMovies(DateTime? fromDate, DateTime? toDate, int pageSize, int pageIndex)
        {
            throw new NotImplementedException();
        }
    }
}

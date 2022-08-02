using Antra.MoviesCRM.Core.Models;

namespace Antra.MoviesCRM.Core.Contracts.Services
{
    public interface IAdminService
    {
        Task<IEnumerable<MoviesReportModel>> GetTopPurchases(DateTime? fromDate = null, DateTime? toDate = null, int pageSize = 30, int pageIndex = 1);
    }
}

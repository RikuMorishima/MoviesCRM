using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Models;

namespace Antra.MoviesCRM.Infrastructure.Services
{
    public class AdminService : IAdminService
    {
        public Task<IEnumerable<MoviesReportModel>> GetTopPurchases(DateTime? fromDate = null, DateTime? toDate = null, int pageSize = 30, int pageIndex = 1)
        {
            throw new NotImplementedException();
        }
    }
}

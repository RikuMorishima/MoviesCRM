using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Entities;

namespace Antra.MoviesCRM.Infrastructure.Repository
{
    public class PurchaseRepository : IPurchaseRepository
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Purchase>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Purchase> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(Purchase entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Purchase entity)
        {
            throw new NotImplementedException();
        }
    }
}

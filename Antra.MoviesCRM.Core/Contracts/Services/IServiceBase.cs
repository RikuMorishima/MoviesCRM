using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.Core.Contracts.Services
{
    public interface IServiceBase<T>
    {
        Task<IEnumerable<T>> GetAllModelAsync();
        Task<T> GetModelByIdAsync(int id);
        Task<int> InsertModelAsync(T model);
        Task<int> UpdateModelAsync(T model);
        Task<int> DeleteModelAsync(int id);
    }
}

using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Entities;

namespace Antra.MoviesCRM.Infrastructure.Repository
{
    public class MovieRepository : IMovieRepository

    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(Movie entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}

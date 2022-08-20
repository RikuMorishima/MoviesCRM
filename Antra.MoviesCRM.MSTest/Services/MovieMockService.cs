using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.MSTest.Services
{
    public class MovieMockService : IMovieService
    {
        public Task<int> DeleteModelAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieModel>> GetAllModelAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MovieModel> GetModelByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationModel<IEnumerable<MovieModel>>> GetMoviesByGenre(int genreId, int pageSize = 30, int pageNum = 1)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertModelAsync(MovieModel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateModelAsync(MovieModel model)
        {
            throw new NotImplementedException();
        }
    }
}

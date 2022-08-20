using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.MoviesCRM.MSTest.Repositories
{
    public class MovieMockRepository : IMovieRepository
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieModel>> GetAllByGenreIdPaginatedAsync(int genreId, int pageSize, int pageNum)
        {
            List<MovieModel> output = new List<MovieModel>();
            for (int i = 1; i < 10;++i)
            {
                output.Add(
                    new MovieModel()
                    {
                        Id = i,
                        Title = "Title "+ i,
                        Genres = new List<MovieGenreModel>
                        {
                            new MovieGenreModel() {MovieId=i,GenreId=genreId },
                            new MovieGenreModel() {MovieId=i,GenreId=genreId+1 },
                            new MovieGenreModel() {MovieId=i,GenreId=genreId+2 },
                            new MovieGenreModel() {MovieId=i,GenreId=genreId+3 },
                        }
                    }
                );
            }
            return Task.FromResult<IEnumerable<MovieModel>>(output);
        }

        public Task<Movie> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            return 100;
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

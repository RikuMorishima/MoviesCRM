using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Antra.MoviesCRM.Infrastructure.Data;

namespace Antra.MoviesCRM.Infrastructure.Repository
{
    public class MovieRepository : BaseRepositoryAsync<CastModel>, IMovieRepository
    {
        public MovieRepository(MovieCrmDbContext _context) : base(_context)
        {
        }

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

        public async Task<IEnumerable<Movie>> GetAllByGenreIdAsync(int genreId)
        {
            /*var genre = await db.Set<Genre>().FindAsync(genreId);

            if (genre == null)
                return null;
            GenreModel genreModel = new GenreModel()
            {
                Id = genre.Id,
                Name = genre.Name
            };

            IEnumerable<MovieGenreModel> movieGenreModels = new List<MovieGenreModel>();
            await db.Set<MovieGenre>().Where(x => x.GenreId == genreId).ForEachAsync(
                async delegate (MovieGenre mg)
                {
                    MovieCastModel movieCastModel = new MovieCastModel()
                    {
                        CastId = mg.CastId,
                        MovieId = mg.MovieId,
                        Character = mg.Character
                    };
                    Movie movie = await db.Set<Movie>().FindAsync(mg.MovieId);
                    movieCastModel.MovieModelRef = new MovieModel()
                    {
                        Id = movie.Id,
                        Title = movie.Title,
                        Overview = movie.Overview,
                        Tagline = movie.Tagline,
                        Budget = movie.Budget,
                        Revenue = movie.Revenue,
                        ImdbUrl = movie.ImdbUrl,
                        TmdbUrl = movie.TmdbUrl,
                        PosterUrl = movie.PosterUrl,
                        BackDropUrl = movie.BackDropUrl,
                        OriginalLanguage = movie.OriginalLanguage,
                        ReleaseDate = movie.ReleaseDate,
                        RunTime = movie.RunTime,
                        Price = movie.Price,
                        CreatedDate = movie.CreatedDate,
                        UpdatedDate = movie.UpdatedDate,
                        UpdatedBy = movie.UpdatedBy,
                        CreatedBy = movie.CreatedBy
                    };
                    _ = castModel.Movies.Append(movieCastModel);
                });
            return castModel;*/
            throw new NotImplementedException();
        }

    }
}

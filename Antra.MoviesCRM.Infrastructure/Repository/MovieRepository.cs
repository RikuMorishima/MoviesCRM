using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Antra.MoviesCRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Antra.MoviesCRM.Infrastructure.Repository
{
    public class MovieRepository : BaseRepositoryAsync<Movie>, IMovieRepository
    {
        public MovieRepository(MovieCrmDbContext _context) : base(_context)
        {
        }

        public async Task<IEnumerable<MovieModel>> GetAllByGenreIdPaginatedAsync(int genreId, int pageSize,int pageNum)
        {
            var genre = await db.Set<Genre>().FindAsync(genreId);

            if (genre == null)
                return null;
        

            IEnumerable<MovieModel> movieModels = new List<MovieModel>();
            _ = db.Set<MovieGenre>().Where(x => x.GenreId == genreId)
                .Skip((pageNum - 1) * pageSize).Take(pageSize).ForEachAsync(
                async delegate (MovieGenre mg)
                {
                    if (mg == null)
                        return;
                    Movie movie = await db.Set<Movie>().FindAsync(mg.MovieId);
                    if (movie == null)
                        return;
                    _ = movieModels.Append(new MovieModel()
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
                    });
                });
            return movieModels;

        }
        public async override Task<Movie> GetByIdAsync(int id)
        {
            var movie = await db.Set<Movie>()
                .Include(b => b.MovieCastsRef)
                .ThenInclude(b=> b.CastRef)
                .Include(b => b.MovieGenresRef)
                .Include(b => b.MovieCrewsRef)
                .Include(b => b.PurchasesRef)
                .Include(b => b.ReviewsRef)
                .Include(b => b.TrailersRef)
                .Include(b => b.FavoritesRef)
                .SingleOrDefaultAsync();

            return movie;
            //movie.MovieCastsRef = db.MovieCasts.Include(m => m.MovieCastsRef).ToList();
        }

    }
}

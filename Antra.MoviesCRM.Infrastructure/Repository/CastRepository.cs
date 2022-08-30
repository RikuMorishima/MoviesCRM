using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Antra.MoviesCRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Antra.MoviesCRM.Infrastructure.Repository
{
    public class CastRepository : BaseRepositoryAsync<Cast>, ICastRepository
    {
        public CastRepository(MovieCrmDbContext _context) : base(_context)
        {

        }

        public async Task<int> AddToMovie(int movieId, int castId, string character)
        {
            var cast = await db.Set<Cast>()
                .Include(b => b.movieCastsRef)
                .FirstOrDefaultAsync();
            var movie = await db.Set<Movie>()
                .Include(b => b.MovieCastsRef)
                .FirstOrDefaultAsync();
            var movieCast = new MovieCast()
            {
                MovieId = movieId,
                CastId = castId,
                Character = character,
                MovieRef = movie,
                CastRef = cast,
            };
            if (cast.movieCastsRef == null)
            {
                cast.movieCastsRef = new List<MovieCast>();
            } 
            if (movie.MovieCastsRef == null)
            {
                movie.MovieCastsRef = new List<MovieCast>();
            }
            cast.movieCastsRef.Add(movieCast);
            movie.MovieCastsRef.Add(movieCast);
            db.Entry(cast).State = EntityState.Modified;
            db.Entry(movie).State = EntityState.Modified;

            return await db.SaveChangesAsync();
        }

        //public override async Task<Cast> GetByIdAsync(int id)
        //{
        //    var cast = await db.Set<Cast>().FindAsync(id);
        //    CastModel castModel = new CastModel()
        //    {
        //        Id = cast.Id,
        //        Name = cast.Name,
        //        Gender = cast.Gender,
        //        TmdbUrl = cast.TmdbUrl,
        //        ProfilePath = cast.ProfilePath,
        //    };
        //    if (cast == null) 
        //        return null;

        //    IEnumerable<MovieCastModel> movieCastModels = new List<MovieCastModel>();
        //    await db.Set<MovieCast>().Where(x => x.CastId == id).ForEachAsync(
        //        async delegate (MovieCast mc)
        //        {
        //            MovieCastModel movieCastModel = new MovieCastModel()
        //            {
        //                CastId = mc.CastId,
        //                MovieId = mc.MovieId,
        //                Character = mc.Character
        //            };
        //            Movie movie = await db.Set<Movie>().FindAsync(mc.MovieId);
        //            if (movie == null)
        //                return;
        //            movieCastModel.MovieModelRef = new MovieModel()
        //            {
        //                Id = movie.Id,
        //                Title = movie.Title,
        //                Overview = movie.Overview,
        //                Tagline = movie.Tagline,
        //                Budget = movie.Budget,
        //                Revenue = movie.Revenue,
        //                ImdbUrl = movie.ImdbUrl,
        //                TmdbUrl = movie.TmdbUrl,
        //                PosterUrl = movie.PosterUrl,
        //                BackDropUrl = movie.BackDropUrl,
        //                OriginalLanguage = movie.OriginalLanguage,
        //                ReleaseDate = movie.ReleaseDate,
        //                RunTime = movie.RunTime,
        //                Price = movie.Price,
        //                CreatedDate = movie.CreatedDate,
        //                UpdatedDate = movie.UpdatedDate,
        //                UpdatedBy = movie.UpdatedBy,
        //                CreatedBy = movie.CreatedBy
        //            };
        //            _ = castModel.Movies.Append(movieCastModel);
        //        });
        //    return castModel;
        //}
    }
}

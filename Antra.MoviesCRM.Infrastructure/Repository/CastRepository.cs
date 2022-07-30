using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Antra.MoviesCRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Antra.MoviesCRM.Infrastructure.Repository
{
    public class CastRepository : BaseRepositoryAsync<CastModel>, ICastRepository
    {
        public CastRepository(MovieCrmDbContext _context) : base(_context)
        {

        }

        public override async Task<CastModel> GetByIdAsync(int id)
        {
            var cast = await db.Set<Cast>().FindAsync(id);
            CastModel castModel = new CastModel()
            {
                Id = cast.Id,
                Name = cast.Name,
                Gender = cast.Gender,
                TmdbUrl = cast.TmdbUrl,
                ProfilePath = cast.ProfilePath,
            };
            if (cast == null) 
                return null;

            IEnumerable<MovieCastModel> movieCastModels = new List<MovieCastModel>();
            await db.Set<MovieCast>().Where(x => x.CastId == id).ForEachAsync(
                async delegate (MovieCast mc)
                {
                    MovieCastModel movieCastModel = new MovieCastModel()
                    {
                        CastId = mc.CastId,
                        MovieId = mc.MovieId,
                        Character = mc.Character
                    };
                    Movie movie = await db.Set<Movie>().FindAsync(mc.MovieId);
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
            return castModel;
        }

        public Task<int> InsertAsync(Cast entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Cast entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Cast>> IRepositoryAsync<Cast>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Cast> IRepositoryAsync<Cast>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

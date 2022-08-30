using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Antra.MoviesCRM.Infrastructure.Repository;

namespace Antra.MoviesCRM.Infrastructure.Services
{
    public class CastService : ICastService
    {
        ICastRepository castRepository;

        public CastService(ICastRepository castRepository)
        {
            this.castRepository = castRepository;
        }

        public async Task<int> AddCast(CastModel model)
        {
            Cast cast = new()
            {
                Id = model.Id,
                Name = model.Name,
                Gender = model.Gender,
                TmdbUrl = model.TmdbUrl,
                ProfilePath = model.ProfilePath
            };
            return await castRepository.InsertAsync(cast);
        }

        public async Task<IEnumerable<CastModel>> GetAllCasts()
        {
            var items = await castRepository.GetAllAsync();
            List<CastModel> models = new List<CastModel>();

            if (items != null)
            {
                foreach (var item in items)
                {
                    var movies = new List<MovieCastModel>();
                    if (item.movieCastsRef != null)
                    {
                        foreach (var movie in item.movieCastsRef)
                        {
                            movies.Add(new MovieCastModel()
                            {
                                MovieId = movie.MovieId,
                                CastId = movie.CastId,
                                Character = movie.Character
                            });
                        }
                    }
                    var model = new CastModel()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Gender = item.Gender,
                        TmdbUrl = item.TmdbUrl,
                        ProfilePath = item.ProfilePath,
                        Movies =movies,
                    };
                    models.Add(model);
                }
            }
            return models;
        }

        public async Task<CastModel> GetCastById(int castId)
        {
            var item = await castRepository.GetByIdAsync(castId);
            if (item == null)
                return null;
            var movies = item.movieCastsRef;
            List<MovieCastModel> movieCastModels = new List<MovieCastModel>();
            if (movies != null)
            {
                foreach (var movie in movies)
                {
                    movieCastModels.Add(new MovieCastModel()
                    {
                        MovieId = movie.MovieId,
                        CastId = movie.CastId,
                        Character = movie.Character
                    });
                }
            }
            var castModel = new CastModel()
            {
                Id = item.Id,
                Name = item.Name,
                TmdbUrl = item.TmdbUrl,
                Gender = item.Gender,
                ProfilePath = item.ProfilePath,
                Movies = movieCastModels
            };
            return castModel;
        }

        public async Task<CastModel> GetCastDetails(int castId)
        {
            var cast = await castRepository.GetByIdAsync(castId);
            CastModel castModel = new CastModel()
            {
                Id = cast.Id,
                Name = cast.Name,
                Gender = cast.Gender,
                TmdbUrl = cast.TmdbUrl,
                ProfilePath = cast.ProfilePath,
            };
            return castModel;
        }

        public async Task<int> PutCast(CastModel model)
        {
            var movieCast = new List<MovieCast>();
            if (model.Movies != null)
            {
                foreach(var movie in model.Movies)
                {
                    movieCast.Add(new MovieCast()
                    {
                        CastId = movie.CastId,
                        MovieId=movie.MovieId,
                        Character=movie.Character,

                    });
                }
            }
            Cast cast = new()
            {
                Id = model.Id,
                Name = model.Name,
                Gender = model.Gender,
                TmdbUrl = model.TmdbUrl,
                ProfilePath = model.ProfilePath,
                movieCastsRef = movieCast
            };
            return await castRepository.UpdateAsync(cast);
        }

        public async Task<int> BindMovieCast(MovieCastModel model)
        {
            return await castRepository.AddToMovie(model.MovieId, model.CastId, model.Character);
        }
    }
}

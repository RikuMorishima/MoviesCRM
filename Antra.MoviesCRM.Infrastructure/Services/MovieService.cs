using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Antra.MoviesCRM.Infrastructure.Repository;

namespace Antra.MoviesCRM.Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        readonly IMovieRepository movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;

        }

        public async Task<int> DeleteModelAsync(int id)
        {
            return await movieRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<MovieModel>> GetAllModelAsync()
        {
            var result = await movieRepository.GetAllAsync();
            List<MovieModel> list = new();
            if (result != null)
            {
                foreach (var item in result)
                {
                    MovieModel model = new()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Overview = item.Overview,
                        Tagline = item.Tagline,
                        Budget = item.Budget,
                        Revenue = item.Revenue,
                        ImdbUrl = item.ImdbUrl,
                        TmdbUrl = item.TmdbUrl,
                        PosterUrl = item.PosterUrl,
                        BackDropUrl = item.BackDropUrl,
                        OriginalLanguage = item.OriginalLanguage,
                        ReleaseDate = item.ReleaseDate,
                        RunTime = item.RunTime,
                        Price = item.Price,
                        CreatedDate = item.CreatedDate,
                        UpdatedDate = item.UpdatedDate,
                        UpdatedBy = item.UpdatedBy,
                        CreatedBy = item.CreatedBy,

                    };
                    list.Add(model);
                }
            }
            return list;
        }

        public async Task<MovieModel> GetModelByIdAsync(int id)
        {
            var item = await movieRepository.GetByIdAsync(id);

            if (item != null)
            {


                MovieModel model = new()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Overview = item.Overview,
                    Tagline = item.Tagline,
                    Budget = item.Budget,
                    Revenue = item.Revenue,
                    ImdbUrl = item.ImdbUrl,
                    TmdbUrl = item.TmdbUrl,
                    PosterUrl = item.PosterUrl,
                    BackDropUrl = item.BackDropUrl,
                    OriginalLanguage = item.OriginalLanguage,
                    ReleaseDate = item.ReleaseDate,
                    RunTime = item.RunTime,
                    Price = item.Price,
                    CreatedDate = item.CreatedDate,
                    UpdatedDate = item.UpdatedDate,
                    UpdatedBy = item.UpdatedBy,
                    CreatedBy = item.CreatedBy,

                };
                return model;
            }
            return null;

        }

        public async Task<PaginationModel<IEnumerable<MovieModel>>> GetMoviesByGenre(int genreId, int pageSize=30, int pageNum=1)
        {
         
            int totalPages = (int) Math.Ceiling((double) movieRepository.GetCount() /pageSize);

            var page = await movieRepository.GetAllByGenreIdPaginatedAsync(genreId, pageSize, pageNum);
            PaginationModel< IEnumerable < MovieModel> > model = new() 
            { 
                Value = page, 
                PageIndex=pageNum, 
                PageSize=pageSize,
                PageCount=totalPages,
            };

            return model;
        }

        public async Task<int> InsertModelAsync(MovieModel model)
        {
            Movie item = new()
            {
                Id = model.Id,
                Title = model.Title,
                Overview = model.Overview,
                Tagline = model.Tagline,
                Budget = model.Budget,
                Revenue = model.Revenue,
                ImdbUrl = model.ImdbUrl,
                TmdbUrl = model.TmdbUrl,
                PosterUrl = model.PosterUrl,
                BackDropUrl = model.BackDropUrl,
                OriginalLanguage = model.OriginalLanguage,
                ReleaseDate = model.ReleaseDate,
                RunTime = model.RunTime,
                Price = model.Price,
                CreatedDate = model.CreatedDate,
                UpdatedDate = model.UpdatedDate,
                UpdatedBy = model.UpdatedBy,
                CreatedBy = model.CreatedBy,

            };
            return await movieRepository.InsertAsync(item);
        }

        public async Task<int> UpdateModelAsync(MovieModel model)
        {
            Movie item = new()
            {
                Id = model.Id,
                Title = model.Title,
                Overview = model.Overview,
                Tagline = model.Tagline,
                Budget = model.Budget,
                Revenue = model.Revenue,
                ImdbUrl = model.ImdbUrl,
                TmdbUrl = model.TmdbUrl,
                PosterUrl = model.PosterUrl,
                BackDropUrl = model.BackDropUrl,
                OriginalLanguage = model.OriginalLanguage,
                ReleaseDate = model.ReleaseDate,
                RunTime = model.RunTime,
                Price = model.Price,
                CreatedDate = model.CreatedDate,
                UpdatedDate = model.UpdatedDate,
                UpdatedBy = model.UpdatedBy,
                CreatedBy = model.CreatedBy,

            };
            return await movieRepository.UpdateAsync(item);
        }
    }
}

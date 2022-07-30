﻿using Antra.MoviesCRM.Core.Contracts.Repository;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Antra.MoviesCRM.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Antra.MoviesCRM.Infrastructure.Repository
{
    public class MovieRepository : BaseRepositoryAsync<MovieModel>, IMovieRepository
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

    }
}

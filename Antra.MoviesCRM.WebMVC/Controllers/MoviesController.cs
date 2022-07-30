using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Antra.MoviesCRM.WebMVC.Controllers
{
    public class MoviesController : Controller
    {
        IMovieService movieService;
        public MoviesController(IMovieService movieService)
        {
            this.movieService = movieService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> MoviesByGenre(int id, int pageSize=30,int pageNumber=1)
        {
            var data = await ((MovieService)movieService)
                .GetMoviesByGenre(id, pageSize, pageNumber);
            return View(data);
        }
    }
}

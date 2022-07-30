using Antra.MoviesCRM.Core.Contracts.Services;
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
        public Task<IActionResult> MoviesByGenre(int id, int pageSize=30,int pageNumber=1)
        {
            //var data = movieService.
            throw new NotImplementedException();
        }
    }
}

using Antra.MoviesCRM.Core.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace Antra.MoviesCRM.WebMVC.Controllers
{
    public class CastController : Controller
    {
        readonly ICastService castService;
        public CastController(ICastService castService)
        {
            this.castService = castService;
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await castService.GetCastDetails(id);
            return View(model);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Antra.MoviesCRM.WebMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

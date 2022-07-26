using Microsoft.AspNetCore.Mvc;

namespace Antra.MoviesCRM.WebMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

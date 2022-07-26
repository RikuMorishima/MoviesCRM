using Microsoft.AspNetCore.Mvc;

namespace Antra.MoviesCRM.WebMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

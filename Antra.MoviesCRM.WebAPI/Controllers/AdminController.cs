using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Antra.MoviesCRM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService adminService;
        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }
        public async Task<IActionResult> GetTopPurchasedMovies(DateTime? fromDate = null, DateTime? toDate = null, int pageSize = 30, int pageIndex = 1)
        {
            return Ok(await adminService.GetTopPurchases(fromDate,toDate,pageSize,pageIndex));
        }
    }
}

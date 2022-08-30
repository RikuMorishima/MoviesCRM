using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Entities;
using Antra.MoviesCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Antra.MoviesCRM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastController : ControllerBase
    {
        private readonly ICastService castService;
        private readonly IMovieService movieService;
        public CastController(ICastService castService, IMovieService movieService)
        {
            this.castService = castService;
            this.movieService = movieService;
        }

        [HttpGet]
        [Route("details")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await castService.GetAllCasts());
        }

        [HttpGet]
        [Route("details/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await castService.GetCastById(id);
            if (item == null) 
                return BadRequest();
            return Ok(item);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddCast(CastModel model)
        {
            return Ok(await castService.AddCast(model));
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateCast(CastModel model)
        {
            return Ok(await castService.PutCast(model));
        }

        [HttpPost]
        [Route("addCastToMovie")]
        public async Task<IActionResult> BindMovieCast(MovieCastModel model)
        {
            var cast = await castService.BindMovieCast(model);
            //await movieService.UpdateModelAsync(movie);
            return Ok();
        }
    }
}

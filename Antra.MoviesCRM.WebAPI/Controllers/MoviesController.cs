using Antra.MoviesCRM.Core.Contracts.Services;
using Antra.MoviesCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Antra.MoviesCRM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService service;
        public MoviesController(IMovieService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("details")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await service.GetAllModelAsync());
        }

        [HttpGet]
        [Route("details/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await service.GetModelByIdAsync(id);
            if (result != null)
                return Ok(result);
            else 
                return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(MovieModel model)
        {
            return Ok(await service.InsertModelAsync(model));
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update(MovieModel model, int id)
        {
            if (ModelState.IsValid && id == model.Id)
            {
                if (await service.UpdateModelAsync(model) > 0)
                {
                    return Ok(model);
                }
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await service.DeleteModelAsync(id) > 0)
            {
                var msg = new { Message = "Movie has been deleted Successfully" };
                return Ok(msg);
            }
            return BadRequest();
        }
    }
}

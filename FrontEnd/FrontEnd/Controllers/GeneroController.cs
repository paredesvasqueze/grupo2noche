using FrontEnd.Filter;
using FrontEnd.Models;
using FrontEnd.Servicio;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;

namespace FrontEnd.Controllers
{
    [TypeFilter(typeof(TokenAuthorizationFilter))]
    [ApiController]
    [Route("[controller]")]
    public class GeneroController : Controller
    {
        private readonly GeneroService _GeneroService;
        private string _token;

        public GeneroController(GeneroService GeneroService)
        {
            _GeneroService = GeneroService;

            //_token = context.HttpContext.Request.Cookies["AuthToken"];
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            var Generos = await _GeneroService.GetGenerosAsync(_token);
            return View(Generos);
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] Genero Genero)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            if (ModelState.IsValid)
            {
                var result = await _GeneroService.CreateGeneroAsync(Genero, _token);
                if (result)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Genero Genero)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            if (ModelState.IsValid)
            {
                var result = await _GeneroService.UpdateGeneroAsync(Genero, _token);
                if (result)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            var result = await _GeneroService.DeleteGeneroAsync(id, _token);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}

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
    public class AreaDeEstudioController : Controller
    {
        private readonly AreaDeEstudioService _AreaDeEstudioService;
        private string _token;

        public AreaDeEstudioController(AreaDeEstudioService AreaDeEstudioService)
        {
            _AreaDeEstudioService = AreaDeEstudioService;

            //_token = context.HttpContext.Request.Cookies["AuthToken"];
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            var AreaDeEstudios = await _AreaDeEstudioService.GetAreaDeEstudiosAsync(_token);
            return View(AreaDeEstudios);
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] AreaDeEstudio AreaDeEstudio)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            if (ModelState.IsValid)
            {
                var result = await _AreaDeEstudioService.CreateAreaDeEstudioAsync(AreaDeEstudio, _token);
                if (result)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] AreaDeEstudio AreaDeEstudio)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            if (ModelState.IsValid)
            {
                var result = await _AreaDeEstudioService.UpdateAreaDeEstudioAsync(AreaDeEstudio, _token);
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
            var result = await _AreaDeEstudioService.DeleteAreaDeEstudioAsync(id, _token);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}

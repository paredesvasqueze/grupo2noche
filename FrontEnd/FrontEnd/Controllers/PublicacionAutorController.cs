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
    public class PublicacionAutorController : Controller
    {
        private readonly PublicacionAutorService _PublicacionAutorService;
        private string _token;

        public PublicacionAutorController(PublicacionAutorService PublicacionAutorService)
        {
            _PublicacionAutorService = PublicacionAutorService;

            //_token = context.HttpContext.Request.Cookies["AuthToken"];
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            var PublicacionAutors = await _PublicacionAutorService.GetPublicacionAutorsAsync(_token);
            return View(PublicacionAutors);
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] PublicacionAutor PublicacionAutor)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            if (ModelState.IsValid)
            {
                var result = await _PublicacionAutorService.CreatePublicacionAutorAsync(PublicacionAutor, _token);
                if (result)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] PublicacionAutor PublicacionAutor)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            if (ModelState.IsValid)
            {
                var result = await _PublicacionAutorService.UpdatePublicacionAutorAsync(PublicacionAutor, _token);
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
            var result = await _PublicacionAutorService.DeletePublicacionAutorAsync(id, _token);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}

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
    public class ArticuloController : Controller
    {
        private readonly ArticuloService _ArticuloService;
        private string _token;

        public ArticuloController(ArticuloService ArticuloService)
        {
            _ArticuloService = ArticuloService;

            //_token = context.HttpContext.Request.Cookies["AuthToken"];
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            var Articulos = await _ArticuloService.GetArticulosAsync(_token);
            return View(Articulos);
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] Articulo Articulo)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            if (ModelState.IsValid)
            {
                var result = await _ArticuloService.CreateArticuloAsync(Articulo, _token);
                if (result)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Articulo Articulo)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            if (ModelState.IsValid)
            {
                var result = await _ArticuloService.UpdateArticuloAsync(Articulo, _token);
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
            var result = await _ArticuloService.DeleteArticuloAsync(id, _token);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}

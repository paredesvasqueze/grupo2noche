using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ArticuloController : ControllerBase
    {
        private readonly ArticuloDomain _ArticuloDomain;

        public ArticuloController(ArticuloDomain ArticuloDomain)
        {
            _ArticuloDomain = ArticuloDomain;
        }

        [HttpGet("ObtenerArticuloTodos")]
        public IActionResult ObtenerArticuloTodos()
        {
            var Articulos = _ArticuloDomain.ObtenerArticuloTodos();
            return Ok(Articulos);
        }

        [HttpPost("InsertarArticulo")]
        public IActionResult InsertarArticulo(Articulo oArticulo)
        {
            var id = _ArticuloDomain.InsertarArticulo(oArticulo);
            return Ok(id);
        }

        [HttpPut("ActualizarArticulo")]
        public IActionResult ActualizarArticulo(Articulo oArticulo)
        {
            var id = _ArticuloDomain.ActualizarArticulo(oArticulo);
            return Ok(id);
        }

        [HttpDelete("EliminaeArticulo")]
        public IActionResult EliminarArticulo(Articulo oArticulo)
        {
            var id = _ArticuloDomain.EliminarArticulo(oArticulo);
            return Ok(id);
        }
    }
}

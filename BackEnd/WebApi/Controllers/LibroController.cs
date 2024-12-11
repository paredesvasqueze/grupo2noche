using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class LibroController : ControllerBase
    {
        private readonly LibroDomain _LibroDomain;

        public LibroController(LibroDomain LibroDomain)
        {
            _LibroDomain = LibroDomain;
        }

        [HttpGet("ObtenerLibroTodos")]
        public IActionResult ObtenerLibroTodos()
        {
            var Libros = _LibroDomain.ObtenerLibroTodos();
            return Ok(Libros);
        }

        [HttpPost("InsertarLibro")]
        public IActionResult InsertarLibro(Libro oLibro)
        {
            var id = _LibroDomain.InsertarLibro(oLibro);
            return Ok(id);
        }

        [HttpPut("ActualizarLibro")]
        public IActionResult ActualizarLibro(Libro oLibro)
        {
            var id = _LibroDomain.ActualizarLibro(oLibro);
            return Ok(id);
        }

        [HttpDelete("EliminarLibro")]
        public IActionResult EliminarLibro(Libro oLibro)
        {
            var id = _LibroDomain.EliminarLibro(oLibro);
            return Ok(id);
        }
    }
}

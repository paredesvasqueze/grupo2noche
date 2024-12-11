using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PublicacionAutorController : ControllerBase
    {
        private readonly PublicacionAutorDomain _PublicacionAutorDomain;

        public PublicacionAutorController(PublicacionAutorDomain PublicacionAutorDomain)
        {
            _PublicacionAutorDomain = PublicacionAutorDomain;
        }

        [HttpGet("ObtenerPublicacionAutorTodos")]
        public IActionResult ObtenerPublicacionAutorTodos()
        {
            var PublicacionAutors = _PublicacionAutorDomain.ObtenerPublicacionAutorTodos();
            return Ok(PublicacionAutors);
        }

        [HttpPost("InsertarPublicacionAutor")]
        public IActionResult InsertarPublicacionAutor(PublicacionAutor oPublicacionAutor)
        {
            var id = _PublicacionAutorDomain.InsertarPublicacionAutor(oPublicacionAutor);
            return Ok(id);
        }

        [HttpPut("ActualizarPublicacionAutor")]
        public IActionResult ActualizarPublicacionAutor(PublicacionAutor oPublicacionAutor)
        {
            var id = _PublicacionAutorDomain.ActualizarPublicacionAutor(oPublicacionAutor);
            return Ok(id);
        }

        [HttpDelete("EliminarPublicacionAutor")]
        public IActionResult EliminarPublicacionAutor(PublicacionAutor oPublicacionAutor)
        {
            var id = _PublicacionAutorDomain.EliminarPublicacionAutor(oPublicacionAutor);
            return Ok(id);
        }
    }
}

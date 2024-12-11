using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PublicacionController : ControllerBase
    {
        private readonly PublicacionDomain _PublicacionDomain;

        public PublicacionController(PublicacionDomain PublicacionDomain)
        {
            _PublicacionDomain = PublicacionDomain;
        }

        [HttpGet("ObtenerPublicacionTodos")]
        public IActionResult ObtenerPublicacionTodos()
        {
            var Publicacions = _PublicacionDomain.ObtenerPublicacionTodos();
            return Ok(Publicacions);
        }

        [HttpPost("InsertarPublicacion")]
        public IActionResult InsertarPublicacion(Publicacion oPublicacion)
        {
            var id = _PublicacionDomain.InsertarPublicacion(oPublicacion);
            return Ok(id);
        }

        [HttpPut("ActualizarPublicacion")]
        public IActionResult ActualizarPublicacion(Publicacion oPublicacion)
        {
            var id = _PublicacionDomain.ActualizarPublicacion(oPublicacion);
            return Ok(id);
        }

        [HttpDelete("EliminarPublicacion")]
        public IActionResult EliminarPublicacion(Publicacion oPublicacion)
        {
            var id = _PublicacionDomain.EliminarPublicacion(oPublicacion);
            return Ok(id);
        }

    }
}

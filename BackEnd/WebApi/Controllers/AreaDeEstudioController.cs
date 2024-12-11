using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AreaDeEstudioController : ControllerBase
    {
        private readonly AreaDeEstudioDomain _AreaDeEstudioDomain;

        public AreaDeEstudioController(AreaDeEstudioDomain AreaDeEstudioDomain)
        {
            _AreaDeEstudioDomain = AreaDeEstudioDomain;
        }

        [HttpGet("ObtenerAreaDeEstudioTodos")]
        public IActionResult ObtenerAreaDeEstudioTodos()
        {
            var AreaDeEstudio = _AreaDeEstudioDomain.ObtenerAreaDeEstudioTodos();
            return Ok(AreaDeEstudio);
        }

        [HttpPost("InsertarAreaDeEstudio")]
        public IActionResult InsertarAreaDeEstudio(AreaDeEstudio oAreaDeEstudio)
        {
            var id = _AreaDeEstudioDomain.InsertarAreaDeEstudio(oAreaDeEstudio);
            return Ok(id);
        }

        [HttpPut("ActualizarAreaDeEstudio")]
        public IActionResult ActualizarAreaDeEstudio(AreaDeEstudio oAreaDeEstudio)
        {
            var id = _AreaDeEstudioDomain.ActualizarAreaDeEstudio(oAreaDeEstudio);
            return Ok(id);
        }

        [HttpDelete("EliminaeAreaDeEstudio")]
        public IActionResult EliminarAreaDeEstudio(AreaDeEstudio oAreaDeEstudio)
        {
            var id = _AreaDeEstudioDomain.EliminarAreaDeEstudio(oAreaDeEstudio);
            return Ok(id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ComentarioController : ControllerBase
    {
        private readonly ComentarioDomain _ComentarioDomain;

        public ComentarioController(ComentarioDomain ComentarioDomain)
        {
            _ComentarioDomain = ComentarioDomain;
        }

        [HttpGet("ObtenerComentarioTodos")]
        public IActionResult ObtenerComentarioTodos()
        {
            var Comentarios = _ComentarioDomain.ObtenerComentarioTodos();
            return Ok(Comentarios);
        }

        [HttpPost("InsertarComentario")]
        public IActionResult InsertarComentario(Comentario oComentario)
        {
            var id = _ComentarioDomain.InsertarComentario(oComentario);
            return Ok(id);
        }

        [HttpPut("ActualizarComentario")]
        public IActionResult ActualizarComentario(Comentario oComentario)
        {
            var id = _ComentarioDomain.ActualizarComentario(oComentario);
            return Ok(id);
        }

        [HttpDelete("EliminaeComentario")]
        public IActionResult EliminarComentario(Comentario oComentario)
        {
            var id = _ComentarioDomain.EliminarComentario(oComentario);
            return Ok(id);
        }
    }
}

using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
        [Route("[controller]")]
        public class AutorController : ControllerBase
        {
            private readonly AutorDomain _AutorDomain;

            public AutorController(AutorDomain AutorDomain)
            {
                _AutorDomain = AutorDomain;
            }

            [HttpGet("ObtenerAutorTodos")]
            public IActionResult ObtenerAutorTodos()
            {
                var Autors = _AutorDomain.ObtenerAutorTodos();
                return Ok(Autors);
            }

            [HttpPost("InsertarAutor")]
            public IActionResult InsertarAutor(Autor oAutor)
            {
                var id = _AutorDomain.InsertarAutor(oAutor);
                return Ok(id);
            }

            [HttpPut("ActualizarAutor")]
            public IActionResult ActualizarAutor(Autor oAutor)
            {
                var id = _AutorDomain.ActualizarAutor(oAutor);
                return Ok(id);
            }

            [HttpDelete("EliminaeAutor")]
            public IActionResult EliminarAutor(Autor oAutor)
            {
                var id = _AutorDomain.EliminarAutor(oAutor);
                return Ok(id);
            }
        }
    
}

using Microsoft.AspNetCore.Mvc;
using CapaDomain;
using CapaEntidad;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class InvestigacionController : ControllerBase
    {
        private readonly InvestigacionDomain _InvestigacionDomain;

        public InvestigacionController(InvestigacionDomain InvestigacionDomain)
        {
            _InvestigacionDomain = InvestigacionDomain;
        }

        [HttpGet("ObtenerInvestigacionTodos")]
        public IActionResult ObtenerInvestigacionTodos()
        {
            var Investigacions = _InvestigacionDomain.ObtenerInvestigacionTodos();
            return Ok(Investigacions);
        }

        [HttpPost("InsertarInvestigacion")]
        public IActionResult InsertarInvestigacion(Investigacion oInvestigacion)
        {
            var id = _InvestigacionDomain.InsertarInvestigacion(oInvestigacion);
            return Ok(id);
        }
        [HttpPut("ActualizarInvestigacion")]
        public IActionResult ActualizarInvestigacion(Investigacion oInvestigacion)
        {
            var id = _InvestigacionDomain.ActualizarInvestigacion(oInvestigacion);
            return Ok(id);
        }

        [HttpDelete("EliminarInvestigacion")]
        public IActionResult EliminarInvestigacion(Investigacion oInvestigacion)
        {
            var id = _InvestigacionDomain.EliminarInvestigacion(oInvestigacion);
            return Ok(id);
        }
    }
}

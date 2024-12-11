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
    public class InvestigacionController : Controller
    {
        private readonly InvestigacionService _InvestigacionService;
        private string _token;

        public InvestigacionController(InvestigacionService InvestigacionService)
        {
            _InvestigacionService = InvestigacionService;

            //_token = context.HttpContext.Request.Cookies["AuthToken"];
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            var Investigacions = await _InvestigacionService.GetInvestigacionsAsync(_token);
            return View(Investigacions);
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] Investigacion Investigacion)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            if (ModelState.IsValid)
            {
                var result = await _InvestigacionService.CreateInvestigacionAsync(Investigacion, _token);
                if (result)
                {
                    return Ok();
                }
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Investigacion Investigacion)
        {
            _token = HttpContext.Request.Cookies["AuthToken"];
            if (ModelState.IsValid)
            {
                var result = await _InvestigacionService.UpdateInvestigacionAsync(Investigacion, _token);
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
            var result = await _InvestigacionService.DeleteInvestigacionAsync(id, _token);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}

using Microsoft.AspNetCore.Mvc;


namespace E1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VisitanteController : ControllerBase
    {
        IVisitanteService VisitanteService;
        public VisitanteController(IVisitanteService _VisitanteService)
        {
            VisitanteService = _VisitanteService;
        }

        [HttpPost]
        public async Task<IActionResult> postVisitante([FromBody] Visitante newVisitante)
        {
            await VisitanteService.Create(newVisitante);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(VisitanteService.Read());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Visitante updVisitante)
        {
            await VisitanteService.Update(id, updVisitante);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await VisitanteService.Delete(id);
            return Ok();
        }
    }
}
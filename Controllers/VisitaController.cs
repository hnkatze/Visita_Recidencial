using Microsoft.AspNetCore.Mvc;


namespace E1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VisitaController : ControllerBase
    {
        IVisitaService VisitaService;
        public VisitaController(IVisitaService _VisitaService)
        {
            VisitaService = _VisitaService;
        }

        [HttpPost]
        public async Task<IActionResult> postVisita([FromBody] Visita newVisita)
        {
            await VisitaService.Create(newVisita);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(VisitaService.Read());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Visita updVisita)
        {
            await VisitaService.Update(id, updVisita);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await VisitaService.Delete(id);
            return Ok();
        }
    }
}
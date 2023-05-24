using Microsoft.AspNetCore.Mvc;


namespace E1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResidenteController : ControllerBase
    {
        IResidenteService ResidenteService;
        public ResidenteController(IResidenteService _ResidenteService)
        {
            ResidenteService = _ResidenteService;
        }

        [HttpPost]
        public async Task<IActionResult> postResidente([FromBody] Residente newResidente)
        {
            await ResidenteService.Create(newResidente);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ResidenteService.Read());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Residente updResidente)
        {
            await ResidenteService.Update(id, updResidente);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await ResidenteService.Delete(id);
            return Ok();
        }
    }
}
using Microsoft.AspNetCore.Mvc;


namespace E1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CasaController : ControllerBase
    {
        ICasaService CasaService;
        public CasaController(ICasaService _CasaService)
        {
            CasaService = _CasaService;
        }

        [HttpPost]
        public async Task<IActionResult> postCasa([FromBody] Casa newCasa)
        {
            await CasaService.Create(newCasa);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(CasaService.Read());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Casa updCasa)
        {
            await CasaService.Update(id, updCasa);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await CasaService.Delete(id);
            return Ok();
        }
    }
}
using Microsoft.AspNetCore.Mvc;


namespace E1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HabitantesCController : ControllerBase
    {
        IHabitantesCService HabitantesCService;
        public HabitantesCController(IHabitantesCService _HabitantesCService)
        {
            HabitantesCService = _HabitantesCService;
        }

        [HttpPost]
        public async Task<IActionResult> postHabitantesC([FromBody] HabitantesC newHabitantesC)
        {
            await HabitantesCService.Create(newHabitantesC);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(HabitantesCService.Read());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] HabitantesC updHabitantesC)
        {
            await HabitantesCService.Update(id, updHabitantesC);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await HabitantesCService.Delete(id);
            return Ok();
        }
    }
}
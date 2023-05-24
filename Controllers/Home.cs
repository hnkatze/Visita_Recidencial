using Microsoft.AspNetCore.Mvc;

namespace E1.Controllers
{
    [ApiController]
    [Route("conndb/[controller]")]
    public class homeController : ControllerBase
    {
        Context dbcontext;
        public homeController(Context db)
        {
            dbcontext = db;
        }

        [HttpGet]
        [Route("ConnDB")]
        public IActionResult ConnDB()
        {
            dbcontext.Database.EnsureCreated();
            return Ok();
        }
    }
}
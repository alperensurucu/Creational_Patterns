using Microsoft.AspNetCore.Mvc;
using Singleton_Design_Pattern_CSharp_AspNetCore_Example.Services;

namespace Singleton_Design_Pattern_CSharp_AspNetCore_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult X()
        {
           DatabaseService databaseService = DatabaseService.GetInstance;

            databaseService.Connected();
            databaseService.DisConnected();

            return Ok(databaseService.Conut);
        }
        [HttpGet("[action]")]
        public IActionResult Y()
        {
            DatabaseService databaseService = DatabaseService.GetInstance;

            databaseService.Connected();
            databaseService.DisConnected();

            return Ok(databaseService.Conut);
        }
    }
}

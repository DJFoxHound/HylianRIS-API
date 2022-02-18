using Microsoft.AspNetCore.Mvc;

namespace HylianRIS_API.Controllers
{
    [ApiController]
    [Route("Connection")]
    public class ConnectionController : ControllerBase
    {
        [HttpGet]
        [Route("IsAlive")]
        public IActionResult IsAlive()
        {
            return Ok(true);
        }
    }
}

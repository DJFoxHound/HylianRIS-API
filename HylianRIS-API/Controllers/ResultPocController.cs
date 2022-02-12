using Hylian.RIS.API.Services.Interfaces;
using Hylian.RIS.API.ViewModels;
using HylianRIS_API.Attributes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;

namespace HylianRIS_API.Controllers
{
    [ApiController]
    [Route("Results")]
    public class ResultPocController : ControllerBase
    {

        private readonly ILogger<ResultPocController> _logger;
        private readonly IWebHostEnvironment _env;
        private readonly IResultPocService _service;

        public ResultPocController(ILogger<ResultPocController> logger, IWebHostEnvironment env, IResultPocService service)
        {
            _logger = logger;
            _env = env;
            _service = service;
        }

        [ClientAppApiKey]
        [HttpPost]
        public async Task<IActionResult> PostResult(RaceResult raceResult)
        {
            try
            {
                var dir = Path.Combine(_env.ContentRootPath, "POC");
                await _service.PostResult(raceResult, dir);
                return Ok();
            }
            catch (UnauthorizedAccessException er)
            {
                return Unauthorized(er.Message);
            }
        }
    }
}

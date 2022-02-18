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
    [Route("Organisation")]
    public class OrganisationController : ControllerBase
    {

        private readonly ILogger<OrganisationController> _logger;
        private readonly IWebHostEnvironment _env;
        private readonly IOrganisationService _service;

        public OrganisationController(ILogger<OrganisationController> logger, IWebHostEnvironment env, IOrganisationService service)
        {
            _logger = logger;
            _env = env;
            _service = service;
        }

        [ClientAppApiKey]
        [HttpGet]
        [Route("IsValidID")]
        public async Task<IActionResult> IsValidID(Guid id)
        {
            try
            {
                var x = await _service.IsValidID(id);
                return Ok(x);
            }
            catch (UnauthorizedAccessException er)
            {
                return Unauthorized(er.Message);
            }
        }
    }
}

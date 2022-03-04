using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public sealed class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("[action]/{carNumber}")]
        public Task<IActionResult> ByNumber([FromRoute] string carNumber)
        {
            _logger.LogError("The method is not implemented for now.");

            throw new NotImplementedException();
        }
    }
}

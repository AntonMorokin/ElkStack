using ElkStack.Constants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ElkStack.Controllers
{
    [ApiController]
    [Route(EndpointRoutes.ApiPrefix + "/" + EndpointRoutes.CarsControllerName)]
    public sealed class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("byNumber/{carNumber}")]
        public Task<IActionResult> GetCarByNumberAsync([FromRoute] string carNumber)
        {
            _logger.LogError("The method is not implemented for now.");

            throw new NotImplementedException();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace opslyApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public abstract class BaseController(ILogger logger) : ControllerBase
    {
        protected readonly ILogger _logger = logger;
    }
}
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace opslyApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public abstract class BaseController(
        ILogger logger, 
        IMediator mediator, 
        IMapper mapper) : ControllerBase
    {
        protected readonly IMediator _mediator = mediator;
        protected readonly ILogger _logger = logger;
        protected readonly IMapper _mapper = mapper;
    }
}
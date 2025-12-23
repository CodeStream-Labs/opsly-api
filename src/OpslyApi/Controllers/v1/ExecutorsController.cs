using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using opslyApi.Controllers;
using OpslyApi.DTOs;

namespace OpslyApi.Controllers.v1
{
    public class ExecutorsController(
        ILogger<ExecutorsController> logger, 
        IMediator mediator,
        IMapper mapper) : BaseController(logger, mediator, mapper)
    {
        [HttpPost("{id}/results")]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetResults([FromRoute] string id, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
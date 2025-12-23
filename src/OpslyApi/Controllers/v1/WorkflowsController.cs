using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using opslyApi.Controllers;
using OpslyApi.DTOs;
using OpslyApi.DTOs.Workflows;

namespace OpslyApi.Controllers.v1
{
    public class WorkflowsController(
        ILogger logger, 
        IMediator mediator,
        IMapper mapper) : BaseController(logger, mediator, mapper)
    {
        [HttpGet]
        [ProducesResponseType(typeof(ApiResponse<List<WorkflowResponse>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetWorkflows([FromQuery] WorkflowFiltersRequest filters, [FromQuery] int pageNumber, [FromQuery] int pageSize, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ApiResponse<WorkflowResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetWorkflows([FromRoute] string id, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostWorkflow([FromBody] WorkflowCreateRequest request, CancellationToken cancellationToken)
        {
            return CreatedAtAction(nameof(GetWorkflows), new { id = 1 }, null);
        }

        [HttpPost("{id}/run")]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> RunWorkflow(CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpPost("{id}/validate")]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ValidateWorkflow(CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutWorkflow([FromRoute] string id, [FromBody] WorkflowCreateRequest request, CancellationToken cancellationToken)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteWorkflow([FromRoute] string id, CancellationToken cancellationToken)
        {
            return NoContent();
        }

        [HttpGet("statuses")]
        [ProducesResponseType(typeof(ApiResponse<List<string>>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetStatuses()
        {
            return Ok();
        }
    }
}
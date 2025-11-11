using Microsoft.AspNetCore.Mvc;
using opslyApi.Controllers;
using OpslyApi.DTOs;
using OpslyApi.DTOs.Workflows;

namespace OpslyApi.Controllers.v1
{
    public class WorkflowController(ILogger logger) : BaseController(logger)
    {
        [HttpGet]
        [ProducesResponseType(typeof(ApiResponse<List<WorkflowResponse>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetWorkflows([FromQuery] WorkflowFiltersRequest filters, [FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ApiResponse<WorkflowResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetWorkflows([FromRoute] string id)
        {
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostWorkflow([FromBody] WorkflowCreateRequest request)
        {
            return CreatedAtAction(nameof(GetWorkflows), new { id = 1 }, null);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutWorkflow([FromRoute] string id, [FromBody] WorkflowCreateRequest request)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteWorkflow([FromRoute] string id)
        {
            return NoContent();
        }
    }
}
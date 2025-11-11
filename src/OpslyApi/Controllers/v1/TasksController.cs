using Microsoft.AspNetCore.Mvc;
using opslyApi.Controllers;
using OpslyApi.DTOs;
using OpslyApi.DTOs.Tasks;

namespace OpslyApi.Controllers.v1
{
    public class TasksController(ILogger<TasksController> logger) : BaseController(logger)
    {
        [HttpGet]
        [ProducesResponseType(typeof(ApiResponse<List<TaskResponse>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTasks([FromQuery] TaskFiltersRequest filters, [FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ApiResponse<TaskResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTask([FromRoute] string id)
        {
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostTask([FromBody] TaskCreateRequest request)
        {
            return CreatedAtAction(nameof(GetTask), new { id = 1 }, null);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutTask([FromRoute] string id, [FromBody] TaskCreateRequest request)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteTask([FromRoute] string id)
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
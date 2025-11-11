using Microsoft.AspNetCore.Mvc;
using opslyApi.Controllers;
using OpslyApi.DTOs;
using OpslyApi.DTOs.Vaults;

namespace OpslyApi.Controllers.v1
{
    public class VaultsController(ILogger<VaultsController> logger) : BaseController(logger)
    {
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ApiResponse<VaultResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetVault([FromRoute] string id)
        {
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostVault([FromBody] VaultCreateRequest request, CancellationToken cancellationToken)
        {
            return CreatedAtAction(nameof(GetVault), new { id = 1 }, null);
        }

        [HttpPost("{id}/resolve")]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ResolveVault([FromRoute] string id, CancellationToken cancellationToken)
        {
            return Ok();
        }
        
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutVault([FromRoute] string id, [FromBody] VaultCreateRequest request, CancellationToken cancellationToken)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ApiResponse<>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteVault([FromRoute] string id, CancellationToken cancellationToken)
        {
            return NoContent();
        }
    }
}
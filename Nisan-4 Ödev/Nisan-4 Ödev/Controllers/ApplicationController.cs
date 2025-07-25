using Microsoft.AspNetCore.Mvc;

namespace Nisan_4_Ödev.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public ApplicationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateApplicationRequest request)
        {
            var response = await _applicationService.CreateAsync(request);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _applicationService.GetAllAsync();
            return Ok(response);
        }

        [HttpPut("{id}/status")]
        public async Task<IActionResult> UpdateStatus(int id, ApplicationState state)
        {
            await _applicationService.UpdateStatusAsync(id, state);
            return NoContent();
        }
    }
}

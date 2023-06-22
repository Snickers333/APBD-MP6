using Cwiczenia6.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionsController : ControllerBase
    {
        private readonly IPrescirptionsService _precsrptionsService;
        public PrescriptionsController(IPrescirptionsService PrescirptionsService)
        {
            _precsrptionsService = PrescirptionsService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getPrescription(int id)
        {
            var output = await _precsrptionsService.GetPrescription(id);
            if (output == null) { return NotFound(); }
            return Ok(output);
        }
    }

}

using Cwiczenia6.Models;
using Cwiczenia6.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorsService _doctorsService;
        public DoctorsController(IDoctorsService doctorsService)
        {
            _doctorsService = doctorsService;
        }

        [HttpGet]
        public async Task<IActionResult> getDoctors()
        {
            var output = await _doctorsService.getDoctorsData();
            return Ok(output);
        }

        [HttpPost]
        public async Task<IActionResult> addDoctor(DoctorPOST doctor)
        {
            await _doctorsService.addDoctor(doctor);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> putDoctor(int id, DoctorPUT doctor)
        {
            await _doctorsService.putDoctor(id, doctor);
            return Ok(id);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteDoctor(int id)
        {
            await _doctorsService.deleteDoctor(id);
            return Ok();
        }
    }
}

using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        protected readonly IEnrollmentService _service;

        public EnrollmentController(IEnrollmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Enrollment>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Enrollment>> GetById(int id)
        {
            var result = await _service.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<List<Course>>> Add(Enrollment enrollment)
        {
            var enrollmentAdded = await _service.Add(enrollment);

            if (enrollmentAdded != null)
            {
                return Created($"enrollment/{enrollmentAdded.ID}", enrollmentAdded);
            }

            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Enrollment enrollment)
        {
            var enrollmentUpdated = await _service.Update(enrollment);

            if (enrollmentUpdated != null)
            {
                return NoContent();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Not a valid id");
            }

            return Ok(await _service.Delete(id));
        }
    }
}

using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        protected readonly ICourseService _service;

        public CourseController(ICourseService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetById(int id)
        {
            var result = await _service.GetById(id);

            if(result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<List<Course>>> Add(Course course)
        {
            var courseAdded = await _service.Add(course);

            if(courseAdded != null)
            {
                return Created($"course/{courseAdded.ID}", courseAdded);
            }

            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Course course)
        {
            var courseUpdated = await _service.Update(course);

            if(courseUpdated != null)
            {
                return NoContent();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if(id <= 0)
            {
                return BadRequest("Not a valid id");
            }

            return Ok(await _service.Delete(id));
        }
    }
}

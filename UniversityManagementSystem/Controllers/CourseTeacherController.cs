using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CourseTeacherController : ControllerBase
    {
        protected readonly ICourseTeacherService _service;

        public CourseTeacherController(ICourseTeacherService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<CourseTeacher>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CourseTeacher>> GetById(int id)
        {
            var result = await _service.GetById(id);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<List<CourseTeacher>>> Add(CourseTeacher courseTeacher)
        {
            var courseTeacherAdded = await _service.Add(courseTeacher);

            if (courseTeacherAdded != null)
            {
                return Created($"courseTeacher/{courseTeacherAdded.ID}", courseTeacherAdded);
            }

            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update(CourseTeacher courseTeacher)
        {
            var courseTeacherUpdated = await _service.Update(courseTeacher);

            if (courseTeacherUpdated != null)
            {
                return NoContent();
            }

            return BadRequest();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            if (id <= 0)
            {

                return BadRequest("Not a valid id!!");
            }

            return Ok(await _service.Delete(id));
        }
    }
}

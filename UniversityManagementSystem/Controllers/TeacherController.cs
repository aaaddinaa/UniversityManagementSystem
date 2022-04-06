using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        protected readonly ITeacherService _service;

        public TeacherController(ITeacherService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Teacher>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetById(int id)
        {
            var result = await _service.GetById(id);

            if(result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<List<Teacher>>> Add(Teacher teacher)
        {
            var teacherAdded = await _service.Add(teacher);

            if(teacherAdded != null)
            {
                return Created($"teacher/{teacherAdded.ID}", teacherAdded);
            }

            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Teacher teacher)
        {
            var teacherUpdated = await _service.Update(teacher);

            if(teacherUpdated != null)
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
                return BadRequest("Not a valid id!!");
            }

            return Ok(await _service.Delete(id));
        }
    }
}

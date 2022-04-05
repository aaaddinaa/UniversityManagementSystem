using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        protected readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetById(int id)
        {
            var result = await _service.GetById(id);

            if(result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> Add(Student student)
        {
            var studentAdded = await _service.Add(student);

            if(studentAdded != null)
            {
                return Created($"student/{studentAdded.ID}", studentAdded);
            }

            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Student student)
        {
            var studentUpdated = await _service.Update(student);

            if(studentUpdated != null)
            {
                return NoContent();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async  Task<ActionResult<bool>> Delete(int id)
        {
            if(id <= 0)
            {
                return BadRequest("Not a valid id!!");
            }

            return Ok(await _service.Delete(id));
        }
    }
}

using BusinessLogic.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        protected readonly IOfficeService _service;

        public OfficeController(IOfficeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Office>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Office>> GetById(int id)
        {
            var result = await _service.GetById(id);

            if(result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<List<Office>>> Add(Office office)
        {
            var officeAdded = await _service.Add(office);

            if(officeAdded != null)
            {
                return Created($"office/{officeAdded.ID}", officeAdded);
            }

            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Office office)
        {
            var officeUpdated = await _service.Update(office);

            if(officeUpdated != null)
            {
                return NoContent();
            }

            return BadRequest();
        }

        [HttpDelete]
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

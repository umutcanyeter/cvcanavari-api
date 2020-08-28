using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Cvcanavari.Business.Interfaces;
using Cvcanavari.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cvcanavari.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CvsController : ControllerBase
    {
        private ICvService _cvService;

        public CvsController(ICvService cvService)
        {
            _cvService = cvService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Cv cv)
        {
            if (ModelState.IsValid)
            {
                await _cvService.Add(cv);
                return Created("", cv);
            }
            return BadRequest("Check body. Model is invalid.");
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(Cv cv)
        {
            if (ModelState.IsValid)
            {
                await _cvService.Update(cv);
                return Ok(cv);
            }
            return BadRequest("Check body. Model is invalid.");
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest("ID cannot be null.(example: cvcanavari.com/api/cvs/delete/1)");
            
            var cvToDelete = await _cvService.GetById((int)id);
            
            if (cvToDelete == null)
                return NotFound("CV not found.");

            await _cvService.Delete(cvToDelete);
            return Ok("Deleted succesfully.");
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var cvs = await _cvService.GetAll();
            return Ok(cvs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int? id)
        {
            if (id == null)
                return BadRequest("Please send id. (Example: cvcanavari.com/api/1)");
            var cv = await _cvService.GetById((int) id);
            if (cv == null)
                return NotFound("CV not found. Check your id value.");
            return Ok(cv);
        }
    }
}

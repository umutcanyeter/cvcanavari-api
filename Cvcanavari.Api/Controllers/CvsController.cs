using System.Threading.Tasks;
using Cvcanavari.Business.Interfaces;
using Cvcanavari.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Cvcanavari.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CvsController : ControllerBase
    {
        private readonly ICvService _cvService;

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

        [HttpGet("searchByFirstname/{firstname}")]
        public async Task<IActionResult> SearchByFirstname(string firstname)
        {
            if (firstname == null)
                return BadRequest("Please send value.");
            var cv = await _cvService.GetListByFilter(c => c.Firstname == firstname);
            if (cv == null)
                return NotFound($"No result for {firstname}");
            return Ok(cv);
        }
        
        [HttpGet("searchByLastname/{lastname}")]
        public async Task<IActionResult> SearchByLastname(string lastname)
        {
            if (lastname == null)
                return BadRequest("Please send value.");
            var cv = await _cvService.GetListByFilter(c => c.Lastname == lastname);
            if (cv == null)
                return NotFound($"No result for {lastname}");
            return Ok(cv);
        }
        
        [HttpGet("searchByPhoneNumber/{phoneNumber}")]
        public async Task<IActionResult> SearchByPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null)
                return BadRequest("Please send value.");
            var cv = await _cvService.GetListByFilter(c => c.PhoneNumber == phoneNumber);
            if (cv == null)
                return NotFound($"No result for {phoneNumber}");
            return Ok(cv);
        }
        
        [HttpGet("searchByEmail/{email}")]
        public async Task<IActionResult> SearchByEmail(string email)
        {
            if (email == null)
                return BadRequest("Please send value.");
            var cv = await _cvService.GetListByFilter(c => c.Email == email);
            if (cv == null)
                return NotFound($"No result for {email}");
            return Ok(cv);
        }

        [HttpGet("searchByCertifications/{certifications}")]
        public async Task<IActionResult> SearchByCertifications(string certifications)
        {
            if (certifications == null)
                return BadRequest("Please send value.");
            var cv = await _cvService.GetListByFilter(c => c.Certifications == certifications);
            if (cv == null)
                return NotFound($"No result for {certifications}");
            return Ok(cv);
        }
        
        [HttpGet("searchByAcademicHistory/{academicHistory}")]
        public async Task<IActionResult> SearchByAcademicHistory(string academicHistory)
        {
            if (academicHistory == null)
                return BadRequest("Please send value.");
            var cv = await _cvService.GetListByFilter(c => c.AcademicHistory1 == academicHistory || c.AcademicHistory2 == academicHistory || c.AcademicHistory3 == academicHistory);
            if (cv == null)
                return NotFound($"No result for {academicHistory}");
            return Ok(cv);
        }
        
        [HttpGet("searchByAwards/{awards}")]
        public async Task<IActionResult> SearchByAwards(string awards)
        {
            if (awards == null)
                return BadRequest("Please send value.");
            var cv = await _cvService.GetListByFilter(c => c.Awards1 == awards || c.Awards2 == awards || c.Awards3 == awards);
            if (cv == null)
                return NotFound($"No result for {awards}");
            return Ok(cv);
        }
        
        [HttpGet("searchByProfessionalExperience/{professionalExperience}")]
        public async Task<IActionResult> SearchByProfessionalExperience(string professionalExperience)
        {
            if (professionalExperience == null)
                return BadRequest("Please send value.");
            var cv = await _cvService.GetListByFilter(c => c.ProfessionalExperience1 == professionalExperience || c.ProfessionalExperience2 == professionalExperience || c.ProfessionalExperience3 == professionalExperience);
            if (cv == null)
                return NotFound($"No result for {professionalExperience}");
            return Ok(cv);
        }
        
        [HttpGet("searchBySkills/{skill}")]
        public async Task<IActionResult> SearchBySkills(string skill)
        {
            if (skill == null)
                return BadRequest("Please send value.");
            var cv = await _cvService.GetListByFilter(c => c.Skills1 == skill || c.Skills2 == skill || c.Skills3 == skill);
            if (cv == null)
                return NotFound($"No result for {skill}");
            return Ok(cv);
        }
    }
}

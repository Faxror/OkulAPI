using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.Entity;

namespace OkulYönetimAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolService _schoolService;

        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet]
        [Route("{action}")]
        public async Task<IActionResult> List()
        {


            return Ok(await _schoolService.GETAllSchool());

        }

        [HttpGet]
        [Route("{action}/{id}")]
        public IActionResult GetStudentsByID(int id)
        {

            return Ok(_schoolService.GetSchoolByID(id));
        }

        [HttpPut]
        [Route("{action}/{id}")]
        public IActionResult Put([FromBody] Schools sch)
        {


            return Ok(_schoolService.updateSchool(sch));

        }

        [HttpDelete]
        [Route("{action}/{id}")]

        public IActionResult Delete(int id)
        {
            _schoolService.deleteSchool(id);
            return Ok();


        }


        [HttpPost("add")]
        public IActionResult Post([FromBody] Schools sc)
        {
            var createdSchool = _schoolService.createstudent(sc);
            return Ok(createdSchool);
        }
    }
}

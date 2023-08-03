using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.Entity;

namespace OkulYönetimAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        [Route("{action}")]
        public async Task<IActionResult> List()
        {


            return Ok(await _teacherService.GETAllTeacher());

        }

        [HttpGet]
        [Route("{action}/{id}")]
        public IActionResult GetStudentsByID(int id)
        {

            return Ok(_teacherService.GetTeacherByID(id));
        }

        [HttpPut]
        [Route("{action}/{id}")]
        public IActionResult Put([FromBody] Teachers tea)
        {


            return Ok(_teacherService.updateteacher(tea));

        }

        [HttpDelete]
        [Route("{action}/{id}")]

        public IActionResult Delete(int id)
        {
            _teacherService.deleteteacher(id);
            return Ok();


        }


        [HttpPost("add")]
        public IActionResult Post([FromBody] Teachers te)
        {
            var createdSchool = _teacherService.createteacher(te);
            return Ok(createdSchool);
        }
    }
}

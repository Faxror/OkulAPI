using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.Entity;

namespace OkulYönetimAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        private readonly ILessonsService lessonsService;

        public LessonsController(ILessonsService lessonsService)
        {
            this.lessonsService = lessonsService;
        }

        [HttpGet]
        [Route("{action}")]
        public async Task<IActionResult> List()
        {


            return Ok(await lessonsService.GETAllLessons());

        }

        [HttpGet]
        [Route("{action}/{id}")]
        public IActionResult GetStudentsByID(int id)
        {

            return Ok(lessonsService.GetLessonsByID(id));
        }

        [HttpPut]
        [Route("{action}/{id}")]
        public IActionResult Put([FromBody] Lessons les)
        {


            return Ok(lessonsService.updateLessons(les));

        }

        [HttpDelete]
        [Route("{action}/{id}")]

        public IActionResult Delete(int id)
        {
            lessonsService.deleteLessons(id);
            return Ok();


        }


        [HttpPost("add")]
        public IActionResult Post([FromBody] Lessons le)
        {
            var createdSchool = lessonsService.createLessons(le);
            return Ok(createdSchool);
        }
    }
}

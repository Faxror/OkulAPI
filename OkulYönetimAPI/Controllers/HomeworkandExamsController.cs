using Microsoft.AspNetCore.Mvc;
using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.Entity;

namespace OkulYönetimAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeworkandExamsController : Controller
    {
        private readonly IHomeworkandExamsService examsService;

        public HomeworkandExamsController(IHomeworkandExamsService examsService)
        {
            this.examsService = examsService;
        }

        [HttpPost("add")]
        public IActionResult Post([FromBody] HomeworkandExams stu, string name)
        {
            try
            {
                var createdStudent = examsService.createhomeworkandexams(stu, name);
                return Ok(createdStudent);
            }
            catch (Exception ex)
            {
                return BadRequest($"Hata: {ex.Message}");
            }
        }

    }
}

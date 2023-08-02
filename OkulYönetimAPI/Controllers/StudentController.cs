using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.DataAccess;
using OkulYönetimAPI.Entity;

namespace OkulYönetimAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IStudentService _schoolService;

        public StudentController(IStudentService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet]
        [Route("{action}")]
        public async Task<IActionResult> List()
        {
     

            return Ok(await _schoolService.GETAllStudents());
            
        }

        [HttpGet]
        [Route("{action}/{id}")]
        public IActionResult GetStudentsByID(int id)
        {
          
            return Ok(_schoolService.GetStudentsByID(id));
        }   

        [HttpPut]
        [Route("{action}/{id}")]
        public IActionResult Put([FromBody] Students stud)
        {


            return Ok(_schoolService.updatestudents(stud)) ;
            
        }
       
        [HttpDelete]
        [Route("{action}/{id}")]    

        public IActionResult Delete(int id)
        {
                _schoolService.deletestudents(id);
                return Ok();
            
            
        }


        [HttpPost("add")] 
        public IActionResult Post([FromBody] Students stu)
        {
            var createdStudent = _schoolService.createstudent(stu);
            return Ok(createdStudent);
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using OkulYönetimAPI.Business.Concrete;
using OkulYönetimAPI.Entity;

namespace OkulYönetimAPI.Controllers
{
    public class LoginController : Controller
    {

        private readonly LoginManager loginManager;

        public LoginController(LoginManager loginManager)
        {
            this.loginManager = loginManager;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] Students students, string İdentity, int password)
        {
            if  (students == null || string.IsNullOrWhiteSpace(students.IdentıtyNumber) || students.StudentsPassword == 0)
            {
                return BadRequest("Identity NO or Password is requierd");
            }

            var stu = loginManager.login(students, İdentity, password);

            if (stu == null)
            {
                return Unauthorized("Geçersiz kimlik veya şifre.");
            }

            
            return Ok("Başarılı giriş!");

            return View();
        }
    }
}

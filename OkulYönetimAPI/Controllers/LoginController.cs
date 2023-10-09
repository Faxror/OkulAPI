    using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.Business.Concrete;
using OkulYönetimAPI.DataAccess;
using OkulYönetimAPI.Entity;

    namespace OkulYönetimAPI.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class LoginController : Controller
        {

            private readonly ILoginService _loginManager;

            private readonly SchoolDBContext dBContext;

        public LoginController(ILoginService loginManager, SchoolDBContext dBContext)
        {
            _loginManager = loginManager;
            this.dBContext = dBContext;
        }



        [HttpPost("LoginUpdate")]
        private IActionResult Update(string İdentityRed, int PasswordRed)
        {
            var student = dBContext.Students;

            if(student == null || string.IsNullOrWhiteSpace(İdentityRed) || PasswordRed == 0)
            {
                return BadRequest("Identity No or Password is requierd");
            }



            return View();
        }


        [HttpPost("Login")]
            public IActionResult Login( string İdentity, int password)
            {
                  var students = dBContext.Students;
                if  (students == null || string.IsNullOrWhiteSpace(İdentity) || password == 0)
                {
                    return BadRequest("Identity NO or Password is requierd");
                }

                var stu = _loginManager.login(İdentity, password);

                if (stu == null)
                {
                    return Unauthorized("Geçersiz kimlik veya şifre.");
                }

            
                return Ok("Başarılı giriş!");

                return View();
            }


        }
    }

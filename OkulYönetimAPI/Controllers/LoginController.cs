    using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.Business.Concrete;
using OkulYönetimAPI.DataAccess;
using OkulYönetimAPI.DataAccess.Abstrack;
using OkulYönetimAPI.Entity;
using OkulYönetimAPI.Models;

namespace OkulYönetimAPI.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class LoginController : Controller
        {

            private readonly ILoginService _loginManager;

            private readonly SchoolDBContext dBContext;

            private readonly ILoginAndRegisterRepository _loginRepository;

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


        [HttpPost("login")]
        public IActionResult Login([FromBody] Students loginRequest)
        {

           
           
            LoginManager loginManager = new LoginManager(_loginRepository, dBContext);

            var response = loginManager.login(loginRequest.IdentıtyNumber, loginRequest.StudentsPassword);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response); 
            }
        }

    }
    }

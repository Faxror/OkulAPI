using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.DataAccess;
using OkulYönetimAPI.DataAccess.Abstrack;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.Concrete
{
    public class LoginManager : ILoginService
    {
        private readonly ILoginAndRegisterRepository repository;

        private readonly SchoolDBContext dBContext;

        public LoginManager(ILoginAndRegisterRepository repository, SchoolDBContext dBContext)
        {
            this.repository = repository;
            this.dBContext = dBContext;
        }

        public void deletedaccount(int id)
        {
            throw new NotImplementedException();
        }

        public Students GetAccountsByID(int id)
        {
            throw new NotImplementedException();
        }

        public ValidationResponse<Students> login(string identity, int password)
        {
            var student = dBContext.Students.FirstOrDefault(s => s.IdentıtyNumber == identity);

            if (student != null && student.StudentsPassword == password)
            {
                return new ValidationResponse<Students>
                {
                    Success = true,
                    Data = student
                };
            }
            else
            {
                // Failed login
                return new ValidationResponse<Students>
                {
                    Success = false,
                    Message = new List<string> { "T.C Kimlik no veya şifreniz hatalı." },
                    Data = null 
                };
            }
        }

      
    }
}

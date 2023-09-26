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
        public LoginManager(ILoginAndRegisterRepository repository)
        {
            this.repository = repository;
        }

        public void deletedaccount(int id)
        {
            throw new NotImplementedException();
        }

        public Students GetAccountsByID(int id)
        {
            throw new NotImplementedException();
        }

        public Students login(Students students, string identity, int password)
        {
            var ss = dBContext.Students.FirstOrDefault(x => x.IdentıtyNumber == identity) ?? throw new Exception();

          
            if (students.StudentsPassword == password)
            {
                return ss;
            }
            

            return null;
        }
    }
}

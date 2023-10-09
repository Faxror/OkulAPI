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

        public Students login(string identity, int password)
        {
            // Find the student with the given identity in the database
            var student = dBContext.Students.FirstOrDefault(s => s.IdentıtyNumber == identity);

            // If a student with the provided identity is found and the password matches, return the student
            if (student != null && student.StudentsPassword == password)
            {
                return student;
            }

            // If no matching student or incorrect password, return null
            return null;
        }

      
    }
}

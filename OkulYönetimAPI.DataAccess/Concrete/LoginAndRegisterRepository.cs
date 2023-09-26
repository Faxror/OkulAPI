using Microsoft.EntityFrameworkCore;
using OkulYönetimAPI.DataAccess.Abstrack;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.DataAccess.Concrete
{
    public class LoginAndRegisterRepository : ILoginAndRegisterRepository
    {
        private readonly SchoolDBContext dbContext;

        public LoginAndRegisterRepository(SchoolDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void deletedaccount(int id)
        {
            var deletedAccounts = GetAccountsByID(id);
            dbContext.Students.Remove(deletedAccounts);
            dbContext.SaveChanges();

        }

        public Students GetAccountsByID(int id)
        {
            return dbContext.Students.Find(id);
        }

        public Students login(Students students)
        {
            throw new NotImplementedException();
        }
    }
}

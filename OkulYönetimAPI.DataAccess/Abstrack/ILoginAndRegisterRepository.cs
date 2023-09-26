using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.DataAccess.Abstrack
{
    public interface ILoginAndRegisterRepository
    {
        Students login(Students students);

        void deletedaccount(int id);

        Students GetAccountsByID(int id);
    }
}

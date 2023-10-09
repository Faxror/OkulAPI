using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.Abstrack
{
    public interface ILoginService
    {
        Students login(string identity, int password);

        void deletedaccount(int id);

        Students GetAccountsByID(int id);
    }
}

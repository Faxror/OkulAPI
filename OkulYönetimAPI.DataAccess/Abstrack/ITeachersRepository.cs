using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.DataAccess.Abstrack
{
    public interface ITeachersRepository
    {
        Task<List<Teachers>> GETAllTeacher();

        Teachers GetTeacherByID(int id);

        Teachers GetTeachersByName(string name);

        Teachers createteacher(Teachers teachers);

        Teachers updateteacher(Teachers teachers);

        void deleteteacher(int id);
    }
}

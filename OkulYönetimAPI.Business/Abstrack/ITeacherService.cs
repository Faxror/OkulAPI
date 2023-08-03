using OkulYönetimAPI.Business.Concrete;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.Abstrack
{
    public interface ITeacherService
    {
        Task<List<Teachers>> GETAllTeacher();

        Teachers GetTeacherByID(int id);

        Teachers GetTeachersByName(string name);

        ValidationResponse<Teachers> createteacher(Teachers teachers);

        ValidationResponse<Teachers> updateteacher(Teachers teachers);

        void deleteteacher(int id);
    }
}

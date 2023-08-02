using OkulYönetimAPI.Business.Concrete;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.Abstrack
{
    public interface ISchoolService
    {
        Task<List<Schools>> GETAllSchool();

        Schools GetSchoolByID(int id);

        Schools GetSchoolByName(string name);

        ValidationResponse<Schools> createstudent(Schools school);

        ValidationResponse<Schools> updateSchool(Schools school);

        void deleteSchool(int id);
    }
}

using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.DataAccess.Abstrack
{
    public interface ISchoolRepository
    {
        Task<List<Schools>> GETAllSchool();

        Schools GetSchoolByID(int id);

        Schools GetSchoolByName(string name);

        Schools createstudent(Schools school);

        Schools updateSchool(Schools school);


        void deleteSchool(int id);
    }
}

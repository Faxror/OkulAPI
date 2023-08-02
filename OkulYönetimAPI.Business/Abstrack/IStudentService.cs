using OkulYönetimAPI.Business.Concrete;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.Abstrack
{
    public interface IStudentService
    {
        Task<List<Students>> GETAllStudents();

        Students GetStudentsByID(int id);

        Students GetStudentsByName(string name);

        ValidationResponse<Students> createstudent(Students students);

        ValidationResponse<Students> updatestudents(Students students);

        void deletestudents(int id);
    }
}

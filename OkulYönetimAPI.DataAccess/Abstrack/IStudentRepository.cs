using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.DataAccess.Abstrack
{
    public interface IStudentRepository
    {
        Task<List<Students>> GETAllStudents();

        Students GetStudentsByID(int id);

        Students GetStudentsByName(string name);

        Students createstudent(Students students);

        Students updatestudents(Students students);

        void deletestudents(int id);
    }
}

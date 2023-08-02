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
    public class SchoolRepository : ISchoolRepository
    {
        private readonly SchoolDBContext _dbContext;

        public SchoolRepository(SchoolDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Students createstudent(Students students)
        {
            _dbContext.Students.Add(students);
            _dbContext.SaveChanges();
            return students;
        }

        public void deletestudents(int id)
        {
           
                var deletedstudents = GetStudentsByID(id);
                _dbContext.Students.Remove(deletedstudents);
                _dbContext.SaveChanges();

            
        }

        public async Task<List<Students>> GETAllStudents()
        {
            using (var  dbcontext = new SchoolDBContext())
            {
                return await dbcontext.Students.ToListAsync();

            }
        }

        public Students GetStudentsByID(int id)
        {
            using (var dbcontext = new SchoolDBContext())
            {
                return  dbcontext.Students.Find(id);

            }
        }

        public Students GetStudentsByName(string name)
        {
            using (var dbcontext = new SchoolDBContext())
            {
                return  dbcontext.Students.FirstOrDefault(x => x.studentname.ToLower() == name.ToLower());

            }
        }

        
        public Students updatestudents(Students students)
        {
            using (var dbcontext = new SchoolDBContext())
            {
                dbcontext.Students.Update(students);
                dbcontext.SaveChanges();
                return students;

            }
        }
    }
}

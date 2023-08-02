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
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDBContext _dbContext;

        public StudentRepository(SchoolDBContext dbContext)
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
         
                return await _dbContext.Students.ToListAsync();

            
        }

        public Students GetStudentsByID(int id)
        {
            
                return _dbContext.Students.Find(id);

            
        }

        public Students GetStudentsByName(string name)
        {
            
                return _dbContext.Students.FirstOrDefault(x => x.studentname.ToLower() == name.ToLower());

            
        }

        
        public Students updatestudents(Students students)
        {
          
                _dbContext.Students.Update(students);
                _dbContext.SaveChanges();
                return students;

            
        }
    }
}

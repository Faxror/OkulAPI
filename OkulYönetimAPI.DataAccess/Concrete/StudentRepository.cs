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

            try
            {
                var existingstudent = _dbContext.Students.Find(students.ıd);

                if (existingstudent != null)
                {
                    // Copy the updated values to the existing entity
                    _dbContext.Entry(existingstudent).CurrentValues.SetValues(students);

                    _dbContext.SaveChanges();
                    return existingstudent;
                }
                else
                {
                    // Handle the case where the school doesn't exist
                    return null; // or throw an exception, return an error message, etc.
                }
            }
            catch (Exception ex)
            {
                throw ex; // Consider logging the exception or handling it in a more appropriate way
            }


        }
    }
}

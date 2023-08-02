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

        public Schools createstudent(Schools school)
        {
           _dbContext.Schools.Add(school);
            _dbContext.SaveChanges();
            return school;
        }

        public void deleteSchool(int id)
        {
            var deletedschool = GetSchoolByID(id);
            _dbContext.Schools.Remove(deletedschool);
            _dbContext.SaveChanges();

        }

        public async Task<List<Schools>> GETAllSchool()
        {
           return await _dbContext.Schools.ToListAsync();
        }

        public Schools GetSchoolByID(int id)
        {
            return _dbContext.Schools.Find(id);
        }

        public Schools GetSchoolByName(string name)
        {
            throw new NotImplementedException();
        }

        public Schools updateSchool(Schools school)
        {
            try
            {
                var existingSchool = _dbContext.Schools.Find(school.id);

                if (existingSchool != null)
                {
                    // Copy the updated values to the existing entity
                    _dbContext.Entry(existingSchool).CurrentValues.SetValues(school);

                    _dbContext.SaveChanges();
                    return existingSchool;
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

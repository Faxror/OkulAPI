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
    public class TeacherRepository : ITeachersRepository
    {
        private readonly SchoolDBContext _dBContext;

        public TeacherRepository(SchoolDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public Teachers createteacher(Teachers teachers)
        {
            _dBContext.Teachers.Add(teachers);
            _dBContext.SaveChanges();
            return teachers;
        }

        public void deleteteacher(int id)
        {
            var deletedteacher = GetTeacherByID(id);
            _dBContext.Teachers.Remove(deletedteacher);
            _dBContext.SaveChanges();
        }

        public async Task<List<Teachers>> GETAllTeacher()
        {
            return await _dBContext.Teachers.ToListAsync();
        }

        public Teachers GetTeacherByID(int id)
        {
            return  _dBContext.Teachers.Find(id);
        }

        public Teachers GetTeachersByName(string name)
        {
            throw new NotImplementedException();
        }

        public Teachers updateteacher(Teachers teachers)
        {
            try
            {
                var existingTeacher = _dBContext.Teachers.Find(teachers.id);

                if (existingTeacher != null)
                {
                    // Copy the updated values to the existing entity
                    _dBContext.Entry(existingTeacher).CurrentValues.SetValues(teachers);

                    _dBContext.SaveChanges();
                    return existingTeacher;
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

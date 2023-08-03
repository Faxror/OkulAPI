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
    public class LessonsRepository : ILessonsRepository
    {
        private readonly SchoolDBContext _dbContext;

        public LessonsRepository(SchoolDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Lessons createLessons(Lessons lessons)
        {
            _dbContext.Lessons.Add(lessons);
            _dbContext.SaveChanges();
            return lessons;
        }

        public void deleteLessons(int id)
        {
            var deletedlessons = GetLessonsByID(id);
               _dbContext.Lessons.Remove(deletedlessons);
               _dbContext.SaveChanges();
            
        }

        public async Task<List<Lessons>> GETAllLessons()
        {
            return await _dbContext.Lessons.ToListAsync();
        }

        public Lessons GetLessonsByID(int id)
        {
            return _dbContext.Lessons.Find(id);
        }

        public Lessons updateLessons(Lessons lessons)
        {
            _dbContext.Lessons.Update(lessons);
            _dbContext.SaveChanges();
            return lessons;
        }
    }
}

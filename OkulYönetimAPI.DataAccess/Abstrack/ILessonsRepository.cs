using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.DataAccess.Abstrack
{
    public interface ILessonsRepository
    {
        Task<List<Lessons>> GETAllLessons();

        Lessons GetLessonsByID(int id);



        Lessons createLessons(Lessons lessons);

        Lessons updateLessons(Lessons lessons);


        void deleteLessons(int id);
    }
}

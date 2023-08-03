using OkulYönetimAPI.Business.Concrete;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.Abstrack
{
    public interface ILessonsService
    {
        Task<List<Lessons>> GETAllLessons();

        Lessons GetLessonsByID(int id);



        ValidationResponse<Lessons> createLessons(Lessons lessons);

        ValidationResponse<Lessons> updateLessons(Lessons lessons);


        void deleteLessons(int id);
    }
}

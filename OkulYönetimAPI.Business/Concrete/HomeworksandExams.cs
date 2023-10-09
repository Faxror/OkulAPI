using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.DataAccess;
using OkulYönetimAPI.DataAccess.Abstrack;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.Concrete
{
    public class HomeworksandExams : IHomeworkandExamsService
    {
        private readonly IHomeWorksandExamsRepository _examsRepository;

        private readonly SchoolDBContext dbContext;

        public HomeworksandExams(IHomeWorksandExamsRepository examsRepository, SchoolDBContext dbContext)
        {
            _examsRepository = examsRepository;
            this.dbContext = dbContext;
        }

        public HomeworkandExams createhomeworkandexams(HomeworkandExams homeworkAndExams,string lessonsname, string name)
        {
            
            var student = dbContext.Students.FirstOrDefault(s => s.studentname == name);
            //var ders = dbContext.Lessons.FirstOrDefault(c => c.lessons == lessonsname);

            if (student == null)
            {
                throw new Exception("Öğrenci bulunamadı");
            }


            dbContext.HomeworkandExams.Add(homeworkAndExams);
            dbContext.SaveChanges();

           
            student.examnotesone = homeworkAndExams.examnotesone;
            student.examnotestwo = homeworkAndExams.examnotetwo;
            student.examnotesthree = homeworkAndExams.examnotethree;
            student.examnotestfour = homeworkAndExams.examnotefour;
            student.homeworks = homeworkAndExams.homeworks;
            


            dbContext.SaveChanges();

            return homeworkAndExams;
        }


        public void deleteHomeworkandExams(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<HomeworkandExams>> GETAllHomeworkandExams()
        {
            throw new NotImplementedException();
        }

        public HomeworkandExams GetHomeworkandExamsByID(int id)
        {
            throw new NotImplementedException();
        }

        public HomeworkandExams GetHomeworkandExamsByName(string name)
        {
            throw new NotImplementedException();
        }

        public HomeworkandExams updatehomeworkandexams(HomeworkandExams homeworkandExams)
        {
            throw new NotImplementedException();
        }
    }
}

using OkulYönetimAPI.DataAccess.Abstrack;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.DataAccess.Concrete
{
    public class HomeworksandExamsRepository : IHomeWorksandExamsRepository
    {
        private readonly SchoolDBContext dBContext;

        public HomeworksandExamsRepository(SchoolDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public HomeworkandExams createhomeworkandexams(HomeworkandExams homeworkandExams)
        {
            throw new NotImplementedException();
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

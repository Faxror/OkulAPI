using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.DataAccess.Abstrack
{
    public interface IHomeWorksandExamsRepository
    {
        Task<List<HomeworkandExams>> GETAllHomeworkandExams();

        HomeworkandExams GetHomeworkandExamsByID(int id);

        HomeworkandExams GetHomeworkandExamsByName(string name);

        HomeworkandExams createhomeworkandexams(HomeworkandExams homeworkandExams);

        HomeworkandExams updatehomeworkandexams(HomeworkandExams homeworkandExams);

        void deleteHomeworkandExams(int id);
    }
}

using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.Abstrack
{
    public interface IHomeworkandExamsService
    {
        Task<List<HomeworkandExams>> GETAllHomeworkandExams();

        HomeworkandExams GetHomeworkandExamsByID(int id);

        HomeworkandExams GetHomeworkandExamsByName(string name);

        HomeworkandExams createhomeworkandexams(HomeworkandExams homeworkAndExams, string lessonsname, string name);

        HomeworkandExams updatehomeworkandexams(HomeworkandExams homeworkandExams);

        void deleteHomeworkandExams(int id);
    }
}

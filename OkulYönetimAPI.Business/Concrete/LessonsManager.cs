using FluentValidation.Results;
using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.Business.ValidationRules;
using OkulYönetimAPI.DataAccess.Abstrack;
using OkulYönetimAPI.DataAccess.Concrete;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.Concrete
{
    public class LessonsManager : ILessonsService
    {
        private readonly ILessonsRepository _lessonsRepository;

        public LessonsManager(ILessonsRepository lessonsRepository)
        {
            _lessonsRepository = lessonsRepository;
        }

        public ValidationResponse<Lessons> createLessons(Lessons lessons)
        {
            LessonsValidation validationrules = new LessonsValidation();
            ValidationResult result = validationrules.Validate(lessons);

            if (!result.IsValid)
            {
                return new ValidationResponse<Lessons>
                {
                    Success = false,
                    Message = result.Errors.Select(c => c.ErrorMessage).ToList(),
                    Data = null
                };
            }
            var createdlessons = _lessonsRepository.createLessons(lessons);

            return new ValidationResponse<Lessons>
            {
                Success = false,

                Data = lessons
            };
        
    }

        public void deleteLessons(int id)
        {
            var lessons = GetLessonsByID(id);
            if(lessons != null)
            {
                _lessonsRepository.deleteLessons(id);
            }
        }

        public async Task<List<Lessons>> GETAllLessons()
        {
          return  await _lessonsRepository.GETAllLessons();
        }

        public Lessons GetLessonsByID(int id)
        {
            return _lessonsRepository.GetLessonsByID(id);
        }

        public ValidationResponse<Lessons> updateLessons(Lessons lessons)
        {
            LessonsValidation validationrules = new LessonsValidation();
            ValidationResult result = validationrules.Validate(lessons);

            if (!result.IsValid)
            {
                var errorResponse = new ValidationResponse<Lessons>
                {
                    Success = false,
                    Message = result.Errors.Select(c => c.ErrorMessage).ToList(),
                    Data = null
                };
               
                return errorResponse;
            }

            var existingStudent = _lessonsRepository.GetLessonsByID(lessons.id);
            if (existingStudent != null)
            {

                var updatedSuccessfully = _lessonsRepository.updateLessons(lessons);

                var sucessresponse = new ValidationResponse<Lessons>
                {
                    Success = true,
                    Data = updatedSuccessfully
                };
                return sucessresponse;
            }
            return null;

        }
    }
}

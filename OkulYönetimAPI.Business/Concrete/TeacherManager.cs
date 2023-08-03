using FluentValidation.Results;
using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.Business.ValidationRules;
using OkulYönetimAPI.DataAccess;
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
    public class TeacherManager : ITeacherService
    {
        private readonly ITeachersRepository _teachersRepository;

        private readonly SchoolDBContext _context;

        public TeacherManager(ITeachersRepository teachersRepository, SchoolDBContext context)
        {
            _teachersRepository = teachersRepository;
            _context = context;
        }

        public ValidationResponse<Teachers> createteacher(Teachers teachers)
        {

            string lessons = teachers.teacheralan;

            Lessons exitigionLessons = _context.Lessons.FirstOrDefault(c => c.lessons == lessons);

            TeacherValidation validationrules = new TeacherValidation();
            ValidationResult result = validationrules.Validate(teachers);
            if(exitigionLessons != null) { 
            if (!result.IsValid)
            {

                return new ValidationResponse<Teachers>
                {
                    Success = false,
                    Message = result.Errors.Select(c => c.ErrorMessage).ToList(),
                    Data = null
                };
            }

            var createdstudents = _teachersRepository.createteacher(teachers);

            return new ValidationResponse<Teachers>
            {
                Success = false,

                Data = teachers
            };
            }
            else
            {
                return new ValidationResponse<Teachers>
                {
                    Success = false,
                    Message = new List<string> { "Oğretmenin alanı veri tabanında bulunamadı. Lütfen geçerli bir okul adı girin." },
                    Data = null
                };
            }
        }

        public void deleteteacher(int id)
        {
            var teacher = GetTeacherByID(id);
            if(teacher != null)
            {
                _teachersRepository.deleteteacher(id);
            }
        }

        public async Task<List<Teachers>> GETAllTeacher()
        {
            return await _teachersRepository.GETAllTeacher();
        }

        public Teachers GetTeacherByID(int id)
        {
            return _teachersRepository.GetTeacherByID(id);
        }

        public Teachers GetTeachersByName(string name)
        {
            throw new NotImplementedException();
        }

        public ValidationResponse<Teachers> updateteacher(Teachers teachers)
        {
            string lessons = teachers.teacheralan;

            Lessons exitigionLessons = _context.Lessons.FirstOrDefault(c => c.lessons == lessons);

            TeacherValidation validationRules = new TeacherValidation();
            ValidationResult result = validationRules.Validate(teachers);
             if(exitigionLessons != null) { 
            if (!result.IsValid)
            {
                var errorResponse = new ValidationResponse<Teachers>
                {
                    Success = false,
                    Message = result.Errors.Select(c => c.ErrorMessage).ToList(),
                    Data = null
                };
                //////// You can log the validation errors if needed
                ////result.Errors.ForEach(c =>
                ////{
                ////    Console.WriteLine(c.PropertyName);
                ////    Console.WriteLine(c.ErrorMessage);
                ////});
                return errorResponse;
            }

            var existingStudent = _teachersRepository.GetTeacherByID(teachers.id);
            if (existingStudent != null)
            {

                var updatedSuccessfully = _teachersRepository.updateteacher(teachers);

                var sucessresponse = new ValidationResponse<Teachers>
                {
                    Success = true,
                    Data = updatedSuccessfully
                };
                return sucessresponse;
            } 
             
            }
            else
            {
                return new ValidationResponse<Teachers>
                {
                    Success = false,
                    Message = new List<string> { "Oğretmenin alanı veri tabanında bulunamadı. Lütfen geçerli bir okul adı girin." },
                    Data = null
                };
            }
            return null;

        }
    }
}

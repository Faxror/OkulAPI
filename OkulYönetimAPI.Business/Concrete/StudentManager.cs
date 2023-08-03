using FluentValidation.Results;
using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.Business.ValidationRules;
using OkulYönetimAPI.DataAccess.Abstrack;
using OkulYönetimAPI.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;
using Azure;
using Microsoft.EntityFrameworkCore;
using OkulYönetimAPI.DataAccess;

namespace OkulYönetimAPI.Business.Concrete
{
    public class StudentManager : IStudentService
    {

        readonly IStudentRepository _schoolRepository;
        readonly SchoolDBContext _dBContext;

        public StudentManager(IStudentRepository schoolRepository, SchoolDBContext dBContext)
        {
            _schoolRepository = schoolRepository;
            _dBContext = dBContext;
        }

        public ValidationResponse<Students> createstudent(Students students)
        {

            string schoolName = students.studentschool;
            string schoolteacher = students.aappointedteachers;
            

            Schools existingSchool = _dBContext.Schools.FirstOrDefault(s => s.schoolname == schoolName);
            Teachers exitingSt = _dBContext.Teachers.FirstOrDefault(c => c.teachername == schoolteacher);

            if (existingSchool != null) 
            {
              if (exitingSt != null) { 
                StudentValidation validationRules = new StudentValidation();
                ValidationResult result = validationRules.Validate(students);
                if (!result.IsValid)
                {
                    return new ValidationResponse<Students>
                    {
                        Success = false,
                        Message = result.Errors.Select(c => c.ErrorMessage).ToList(),
                        Data = null
                    };
                }

               
                var createdStudent = _schoolRepository.createstudent(students);

                return new ValidationResponse<Students>
                {
                    Success = true,
                    Data = createdStudent
                };
                }
              else
                {
                    return new ValidationResponse<Students>
                    {
                        Success = false,
                        Message = new List<string> { "Rehberlik oğretmeni veri tabınında bulunamadı. Lütfen geçerli bir okul adı girin." },
                        Data = null
                    };
                }
            }
            else 
            {
               
                return new ValidationResponse<Students>
                {
                    Success = false,
                    Message = new List<string> { "Öğrencinin okulu veri tabanında bulunamadı. Lütfen geçerli bir okul adı girin." },
                    Data = null
                };
            }

        }

        public void deletestudents(int id)
        {
            var student = _schoolRepository.GetStudentsByID(id);
            if (student != null)
            {
                _schoolRepository.deletestudents(id);

            }
        }

        public Task<List<Students>> GETAllStudents()
        {
            return _schoolRepository.GETAllStudents();
        }

        public Students GetStudentsByID(int id)
        {
            // return _schoolRepository.GetStudentsByID(id);

            var student = _schoolRepository.GetStudentsByID(id);
            return student;
        }

        public Students GetStudentsByName(string name)
        {
            return _schoolRepository.GetStudentsByName(name);
        }



        public ValidationResponse<Students> updatestudents(Students students)
        {

            StudentValidation validationRules = new StudentValidation();
            ValidationResult result = validationRules.Validate(students);

            if (!result.IsValid)
            {
                var errorResponse = new ValidationResponse<Students>
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

            var existingStudent = _schoolRepository.GetStudentsByID(students.ıd);
            if (existingStudent != null)
            {
               
                var updatedSuccessfully = _schoolRepository.updatestudents(students);

                var sucessresponse = new ValidationResponse<Students>
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

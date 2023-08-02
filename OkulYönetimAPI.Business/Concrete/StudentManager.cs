using FluentValidation.Results;
using OkulYönetimAPI.Business.Abstrack;
using OkulYönetimAPI.Business.ValidationRules;
using OkulYönetimAPI.DataAccess.Abstrack;
using OkulYönetimAPI.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;
using Azure;

namespace OkulYönetimAPI.Business.Concrete
{
    public class StudentManager : IStudentService
    {

        readonly IStudentRepository _schoolRepository;

        public StudentManager(IStudentRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        public ValidationResponse<Students> createstudent(Students students)
        {
            StudentValidation validationrules = new StudentValidation();
            ValidationResult result = validationrules.Validate(students);
            if (!result.IsValid)
            {

                return new ValidationResponse<Students>
                {
                    Success = false,
                    Message = result.Errors.Select(c => c.ErrorMessage).ToList(),
                    Data = null
                };               
            }

            var createdstudents = _schoolRepository.createstudent(students);

            return new ValidationResponse<Students>
            {
                Success = false,
               
                Data = students
            };


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

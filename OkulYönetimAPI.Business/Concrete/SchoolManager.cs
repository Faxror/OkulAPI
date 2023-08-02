using FluentValidation;
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
    public class SchoolManager : ISchoolService
    {
        private readonly ISchoolRepository schoolRepository;

        public SchoolManager(ISchoolRepository schoolRepository)
        {
            this.schoolRepository = schoolRepository;
        }

        public ValidationResponse<Schools> createstudent(Schools school)
        {
            SchoolValidation validationrules = new SchoolValidation();
            ValidationResult result = validationrules.Validate(school);
            if (!result.IsValid)
            {

                return new ValidationResponse<Schools>
                {
                    Success = false,
                    Message = result.Errors.Select(c => c.ErrorMessage).ToList(),
                    Data = null
                };
            }

            var createdstudents = schoolRepository.createstudent(school);

            return new ValidationResponse<Schools>
            {
                Success = false,

                Data = school
            };
        }

        public void deleteSchool(int id)
        {
            var student = schoolRepository.GetSchoolByID(id);
            if (student != null)
            {
                schoolRepository.deleteSchool(id);

            }
        }

        public Task<List<Schools>> GETAllSchool()
        {
            return schoolRepository.GETAllSchool();
        }

        public Schools GetSchoolByID(int id)
        {
            var student = schoolRepository.GetSchoolByID(id);
            return student;
        }

        public Schools GetSchoolByName(string name)
        {
            throw new NotImplementedException();
        }

        public ValidationResponse<Schools> updateSchool(Schools school)
        {
            SchoolValidation validationRules = new SchoolValidation();
            ValidationResult result = validationRules.Validate(school);

            if (!result.IsValid)
            {
                var errorResponse = new ValidationResponse<Schools>
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

            var existingStudent = schoolRepository.GetSchoolByID(school.id);
            if (existingStudent != null)
            {

                var updatedSuccessfully = schoolRepository.updateSchool(school);

                var sucessresponse = new ValidationResponse<Schools>
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

using FluentValidation;
using FluentValidation.Results;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.ValidationRules
{
    public class StudentValidation : AbstractValidator<Students>
    {
        public StudentValidation()
        {
            RuleFor(x => x.studentname).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");
            RuleFor(x => x.studentsurname).NotEmpty().WithMessage("Soyisim alanı boş bırakılamaz.");
            RuleFor(x => x.studentnumber).NotEmpty().WithMessage("Numara alanı boş bırakılamaz.");
            RuleFor(x => x.studentschool).NotEmpty().WithMessage("Okul ismi alanı boş bırakılamaz.");
        }

      
    }
}

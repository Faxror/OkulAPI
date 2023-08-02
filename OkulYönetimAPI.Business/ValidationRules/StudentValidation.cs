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
            RuleFor(x => x.studentname).NotEmpty().WithMessage("İsim Alanı Boş Bırakılamaz.");
        }

      
    }
}

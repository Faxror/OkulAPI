using FluentValidation;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.ValidationRules
{
    public class TeacherValidation : 
        AbstractValidator<Teachers>
    {
        public TeacherValidation()
        {
            RuleFor(x => x.teachersurname).NotEmpty().WithMessage("Oğretmen ismi alanı boş bırakılamaz.");
            RuleFor(x => x.teachersurname).NotEmpty().WithMessage("Oğretmen soyisim alanı boş bırakılamaz.");
            RuleFor(x => x.teachernumber).NotEmpty().WithMessage("Oğretmen numarası alanı boş bırakılamaz.");
        }
    }
}

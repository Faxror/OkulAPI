using FluentValidation;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.ValidationRules
{
    public class SchoolValidation : AbstractValidator<Schools>
    {
        public SchoolValidation()
        {
            RuleFor(x => x.schoolname).NotEmpty().WithMessage("Okul ismi alanı boş bırakılamaz.");
            RuleFor(x => x.schooladress).NotEmpty().WithMessage("Okul adress alanı boş bırakılamaz.");
            RuleFor(x => x.schoolphone).NotEmpty().WithMessage("Okul numarası alanı boş bırakılamaz.");
        }
    }
}

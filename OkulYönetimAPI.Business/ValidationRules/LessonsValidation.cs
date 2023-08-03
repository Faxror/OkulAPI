using FluentValidation;
using OkulYönetimAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Business.ValidationRules
{
    public class LessonsValidation : 
        AbstractValidator<Lessons>
    {
        public LessonsValidation()
        {
            RuleFor(x => x.lessons).NotEmpty().WithMessage("Alan ismi  boş bırakılamaz.");
            
        }
    }
}

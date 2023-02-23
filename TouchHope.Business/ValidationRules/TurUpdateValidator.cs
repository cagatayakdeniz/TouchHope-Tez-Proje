using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Dtos;

namespace TouchHope.Business.ValidationRules
{
    public class TurUpdateValidator : AbstractValidator<TurUpdateDto>
    {
        public TurUpdateValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Ad alanı boş geçilemez");
        }
    }
}

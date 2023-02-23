using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Dtos;

namespace TouchHope.Business.ValidationRules
{
    public class TurAddValidator: AbstractValidator<TurAddDto>
    {
        public TurAddValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Ad alanı boş geçilemez");
        }
    }
}

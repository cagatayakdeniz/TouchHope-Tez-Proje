using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Dtos;

namespace TouchHope.Business.ValidationRules
{
    public class KullaniciUpdateValidator: AbstractValidator<KullaniciUpdateDto>
    {
        public KullaniciUpdateValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez.");
            RuleFor(x => x.TelefonNo).NotEmpty().WithMessage("Telefon No alanı boş geçilemez.");
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Soyad alanı boş geçilemez.");
            RuleFor(x => x.IlId).NotEmpty().WithMessage("İl alanı boş geçilemez.");
            //RuleFor(x => x.DogumTarih).NotEmpty().WithMessage("Doğum Tarihi alanı boş geçilemez.");
        }
    }
}

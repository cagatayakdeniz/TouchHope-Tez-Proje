using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Dtos;

namespace TouchHope.Business.ValidationRules
{
    public class KullaniciSignInValidator : AbstractValidator<KullaniciSignInDto>
    {
        public KullaniciSignInValidator()
        {
            RuleFor(x => x.KullaniciAd).NotEmpty().WithMessage("Kullanıcı adı alanı zorunludur");
            RuleFor(x => x.KullaniciAd).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
        }
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchHope.Entities.Concrete;
using TouchHope.Entities.Dtos;

namespace TouchHope.Business.ValidationRules
{
    public class KullaniciSignUpValidator: AbstractValidator<Kullanici>
    {
        public KullaniciSignUpValidator()
        {
            RuleFor(x => x.KullaniciAd).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez");
            RuleFor(x => x.Sifre).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email boş geçilemez");
            RuleFor(x => x.TelefonNo).NotEmpty().WithMessage("Telefon No boş geçilemez");
            RuleFor(x => x.DogumTarih).NotEmpty().WithMessage("Doğum Tarihi boş geçilemez");
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Ad boş geçilemez");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Soyad boş geçilemez");
            RuleFor(x => x.CinsiyetId).NotEmpty().WithMessage("Cinsiyet boş geçilemez");
            RuleFor(x => x.IlId).NotEmpty().WithMessage("İl boş geçilemez");
        }
    }
}

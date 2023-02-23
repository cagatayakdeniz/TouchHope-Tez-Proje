using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.ApiServices.Abstract
{
    public interface IAuthApiService
    {
        Task<bool> GirisYap(KullaniciSignInModel kullaniciSignInModel);
        KullaniciModel GetirAktifKullanici();
        Task<KullaniciSignUpModel> KayitOl(KullaniciSignUpModel kullaniciSignUpModel);
        Task Guncelle(KullaniciUpdateModel kullaniciUpdateModel);
    }
}

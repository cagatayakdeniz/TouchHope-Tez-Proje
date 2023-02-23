using JwtProje.Business.StringInfos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Business.Abstract;
using TouchHope.WebUI.ApiServices.Abstract;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.Controllers
{
    public class AuthController : Controller
    {
        private IAuthApiService _authApiService;
        private ICinsiyetApiService _cinsiyetApiService;
        private IIlApiService _ilApiService;
        private IKullaniciService _kullaniciService;
        public AuthController(IAuthApiService authApiService, ICinsiyetApiService cinsiyetApiService, IIlApiService ilApiService
            , IKullaniciService kullaniciService)
        {
            _ilApiService = ilApiService;
            _cinsiyetApiService = cinsiyetApiService;
            _authApiService = authApiService;
            _kullaniciService = kullaniciService;
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(KullaniciSignInModel kullaniciSignInModel)
        {
            if(ModelState.IsValid)
            {
                if (await _authApiService.GirisYap(kullaniciSignInModel))
                {
                    var onlineKisi = _authApiService.GetirAktifKullanici();

                    if(onlineKisi.Roles.Contains(RoleInfo.Admin))
                    {
                        return RedirectToAction("Index", "AnaSayfa", new { area = "Admin" });
                    }
                    else
                    {
                        return RedirectToAction("Index", "AnaSayfa", new { area = "Gonullu" });
                    }

                }
                ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı !");
            }
            return View("SignIn",kullaniciSignInModel);
        }

        public async Task<IActionResult> SignUp()
        {
            ViewBag.Cinsiyetler = new SelectList(await _cinsiyetApiService.GetirHepsi(), "Id", "Ad");
            ViewBag.Iller = new SelectList(await _ilApiService.GetirHepsi(), "Id", "Ad");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(KullaniciSignUpModel kullaniciSignUpModel)
        {
            if(ModelState.IsValid)
            {
                if(!await _kullaniciService.GetirKullaniciByAd(kullaniciSignUpModel.KullaniciAd))
                {
                    ViewBag.Cinsiyetler = new SelectList(await _cinsiyetApiService.GetirHepsi(), "Id", "Ad");
                    ViewBag.Iller = new SelectList(await _ilApiService.GetirHepsi(), "Id", "Ad");
                    ModelState.AddModelError("", "Bu kullanıcı adı kullanılıyor");
                    return View("SignUp");
                }
                await _authApiService.KayitOl(kullaniciSignUpModel);

                TempData["message"] = "Kayıt İşlemi Başarılı";
                return RedirectToAction("SignIn");

                
            }
            return View("SignUp");
        }
    }
}

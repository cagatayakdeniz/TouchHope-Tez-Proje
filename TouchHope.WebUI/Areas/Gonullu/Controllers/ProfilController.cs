using JwtProje.Business.StringInfos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.ActionFilters;
using TouchHope.WebUI.ApiServices.Abstract;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.Areas.Gonullu.Controllers
{// Çağatay Akdeniz //
    [Area("Gonullu")]
    [JwtAuthorize(Roller = RoleInfo.Gonullu)]
    public class ProfilController : Controller
    {
        private IGonulluApiService _gonulluApiService;
        private IAuthApiService _authApiService;
        private IIlApiService _ilApiService;
        private ICinsiyetApiService _cinsiyetApiService;
        private ISayiApiService _sayiApiService;
        public ProfilController(IGonulluApiService gonulluApiService, IAuthApiService authApiService, IIlApiService ilApiService,
            ICinsiyetApiService cinsiyetApiService, ISayiApiService sayiApiService)
        {
            _sayiApiService = sayiApiService;
            _cinsiyetApiService = cinsiyetApiService;
            _ilApiService = ilApiService;
            _authApiService = authApiService;
            _gonulluApiService = gonulluApiService;
        }

        public async Task<IActionResult> Index()
        {
            TempData["active"] = "profil";

            ViewBag.Iller = new SelectList(await _ilApiService.GetirHepsi(), "Id", "Ad");
            ViewBag.Cinsiyetler = new SelectList(await _cinsiyetApiService.GetirHepsi(), "Id", "Ad");
            var kullanici = _authApiService.GetirAktifKullanici();
            var gonullu = await _gonulluApiService.GetirById(kullanici.Id);

            ViewBag.BildirimSayisi = _sayiApiService.BildirimSayisi(kullanici.Id);
            ViewBag.AktifHastaHayvanSayisi = _sayiApiService.AktifGorevHastaHayvanSayisi(kullanici.Id);
            ViewBag.IyilestirdigimHastaHayvanSayisi = _sayiApiService.IyilestirdigimHayvanSayisi(kullanici.Id);
            ViewBag.YazdigimToplamRaporSayisi = _sayiApiService.YazdigimToplamRaporSayisi(kullanici.Id);

            return View(new KullaniciUpdateModel
            {
                Id = kullanici.Id,
                KullaniciAd = gonullu.KullaniciAd,
                Ad = gonullu.Ad,
                Soyad = gonullu.Soyad,
                Email = gonullu.Email,
                TelefonNo = gonullu.TelefonNo,
                IlId = gonullu.IlId,
                CinsiyetId = gonullu.CinsiyetId,
            });
        }

        [HttpPost]
        public async Task<IActionResult> Guncelle(KullaniciUpdateModel kullaniciUpdateModel)
        {
            TempData["active"] = "profil";

            if (ModelState.IsValid)
            {
                await _authApiService.Guncelle(kullaniciUpdateModel);
                TempData["messageGuncelle"] = "Profil Güncelleme İşlemi Başarılı.";
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}

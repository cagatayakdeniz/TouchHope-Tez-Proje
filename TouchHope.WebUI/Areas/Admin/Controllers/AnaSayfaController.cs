using JwtProje.Business.StringInfos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.ActionFilters;
using TouchHope.WebUI.ApiServices.Abstract;
// Çağatay Akdeniz //
namespace TouchHope.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [JwtAuthorize(Roller = RoleInfo.Admin)]
    public class AnaSayfaController : Controller
    {
        private ISayiApiService _sayiApiService;
        private IAuthApiService _authApiService;
        public AnaSayfaController(ISayiApiService sayiApiService, IAuthApiService authApiService)
        {
            _sayiApiService = sayiApiService;
            _authApiService = authApiService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "anasayfa";

            var kullanici = _authApiService.GetirAktifKullanici();
            ViewBag.IhbarSayisi = _sayiApiService.IhbarSayisi();
            ViewBag.HastaHayvanSayisi = _sayiApiService.HastaHayvanSayisi();
            ViewBag.KaybolanHayvanSayisi = _sayiApiService.KaybolanHayvanSayisi();
            ViewBag.SahiplendirilecekHayvanSayisi = _sayiApiService.SahiplendirilecekHayvanSayisi();
            ViewBag.IyilesenHayvanSayisi = _sayiApiService.IyilesenHayvanSayisi();
            ViewBag.AktifHayvanSayisi = _sayiApiService.AktifIlgilenilenHayvanSayisi();
            ViewBag.PasifHayvanSayisi = _sayiApiService.GonulluAtanmayanHayvanSayisi();
            ViewBag.BildirimSayisi = _sayiApiService.BildirimSayisi(kullanici.Id);
            ViewBag.ToplamRaporSayisi = _sayiApiService.ToplamRaporSayisi();
            ViewBag.GonulluSayisi = _sayiApiService.GonulluSayisi();
            ViewBag.GonulluErkekSayisi = _sayiApiService.GonulluErkekSayisi();
            ViewBag.GonulluKadinSayisi = _sayiApiService.GonulluKadinSayisi();
            return View();
        }

        public IActionResult CikisYap()
        {
            HttpContext.Session.Remove("token");
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}

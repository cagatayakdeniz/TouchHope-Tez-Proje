using JwtProje.Business.StringInfos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.ActionFilters;
using TouchHope.WebUI.ApiServices.Abstract;
// Çağatay Akdeniz //
namespace TouchHope.WebUI.Areas.Gonullu.Controllers
{
    [Area("Gonullu")]
    [JwtAuthorize(Roller = RoleInfo.Gonullu)]
    public class AnaSayfaController : Controller
    {
        private IAuthApiService _authApiService;
        private ISayiApiService _sayiApiService;
        public AnaSayfaController(IAuthApiService authApiService, ISayiApiService sayiApiService)
        {
            _sayiApiService = sayiApiService;
            _authApiService = authApiService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "anasayfa";

            var kullanici = _authApiService.GetirAktifKullanici();
            ViewBag.BildirimSayisi = _sayiApiService.BildirimSayisi(kullanici.Id);
            ViewBag.AktifHastaHayvanSayisi = _sayiApiService.AktifGorevHastaHayvanSayisi(kullanici.Id);
            ViewBag.IyilestirdigimHastaHayvanSayisi = _sayiApiService.IyilestirdigimHayvanSayisi(kullanici.Id);
            ViewBag.YazdigimToplamRaporSayisi = _sayiApiService.YazdigimToplamRaporSayisi(kullanici.Id);
            return View();
        }

        public IActionResult CikisYap()
        {
            HttpContext.Session.Remove("token");
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}

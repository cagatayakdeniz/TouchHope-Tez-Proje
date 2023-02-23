using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.ApiServices.Abstract;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IHayvanApiService _hayvanApiService;
        private IIhbarApiService _ihbarApiService;
        private IIlApiService _ilApiService;
        public HomeController(IHayvanApiService hayvanApiService, IIhbarApiService ihbarApiService, IIlApiService ilApiService)
        {
            _ilApiService = ilApiService;
            _hayvanApiService = hayvanApiService;
            _ihbarApiService = ihbarApiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> KayipListesi(int sehir)
        {
            if (sehir != 0 && sehir != -1)
            {
                ViewBag.Iller = new SelectList(await _ilApiService.GetirHepsi(), "Id", "Ad");
                var il = await _ilApiService.GetirById(sehir);
                ViewBag.Sehir = il.Ad;
                return View(await _hayvanApiService.GetirSehireGoreKaybolanHayvanlar(sehir));
            }
            else
            {
                ViewBag.Iller = new SelectList(await _ilApiService.GetirHepsi(), "Id", "Ad");
                return View(await _hayvanApiService.GetirHepsiKaybolanHayvanlar());
            }       
        }

        public async Task<IActionResult> SahiplendirilecekListesi(int sehir)
        {
            if(sehir != 0 && sehir != -1)
            {
                ViewBag.Iller = new SelectList(await _ilApiService.GetirHepsi(), "Id", "Ad");
                var il = await _ilApiService.GetirById(sehir);
                ViewBag.Sehir = il.Ad;
                return View(await _hayvanApiService.GetirSehireGoreSahiplendirilecekHayvanlar(sehir));
            }
            else
            {
                ViewBag.Iller = new SelectList(await _ilApiService.GetirHepsi(), "Id", "Ad");
                return View(await _hayvanApiService.GetirHepsiSahiplendirilecekHayvanlar());
            }
        }

        [HttpPost]
        public async Task<IActionResult> KayipEkle(KayipAddModel model)
        {
            await _hayvanApiService.EkleKayip(model);
            TempData["kayipEklendi"] = "Kayıp Ekleme İşlemi Başarılı";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> SahiplendirEkle(SahiplendirAddModel model)
        {
            await _hayvanApiService.EkleSahiplendir(model);
            TempData["sahiplendirEklendi"] = "Sahiplendirme Ekleme İşlemi Başarılı";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> IhbarEkle(IhbarAddModel model)
        {
            await _ihbarApiService.Ekle(model);
            TempData["ihbarEklendi"] = "İhbar Ekleme İşlemi Başarılı";
            return RedirectToAction("Index");
        }
    }
}

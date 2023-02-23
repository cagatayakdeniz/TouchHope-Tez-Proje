using JwtProje.Business.StringInfos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.ActionFilters;
using TouchHope.WebUI.ApiServices.Abstract;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.Areas.Gonullu.Controllers
{
    [Area("Gonullu")]
    [JwtAuthorize(Roller = RoleInfo.Gonullu)]
    public class HastaHayvanController : Controller
    {
        private IAuthApiService _authApiService;
        private IHastaHayvanApiService _hastaHayvanApiService;
        private IHayvanGonulluApiService _hayvanGonulluApiService;
        private IRaporApiService _raporApiService;
        private IBildirimApiService _bildirimApiService;
        public HastaHayvanController(IHastaHayvanApiService hastaHayvanApiService, IAuthApiService authApiService, IRaporApiService raporApiService
            , IBildirimApiService bildirimApiService, IHayvanGonulluApiService hayvanGonulluApiService)
        {
            _hayvanGonulluApiService = hayvanGonulluApiService;
            _bildirimApiService = bildirimApiService;
            _raporApiService = raporApiService;
            _authApiService = authApiService;
            _hastaHayvanApiService = hastaHayvanApiService;
        }

        public async Task<IActionResult> Index()
        {
            TempData["active"] = "hastaHayvan";

            var kullanici = _authApiService.GetirAktifKullanici();
            return View(await _hastaHayvanApiService.GetirAktifGorevHastaHayvanById(kullanici.Id));
        }

        public async Task<IActionResult> IyilestirilenHayvanlar()
        {
            TempData["active"] = "iyilesenHayvan";

            var kullanici = _authApiService.GetirAktifKullanici();
            return View(await _hastaHayvanApiService.GetirIyilestirilenHastaHayvanById(kullanici.Id));
        }

        public async Task<IActionResult> IyilestirilenDetayHastaHayvan(int id)
        {
            TempData["active"] = "iyilesenHayvan";

            var hastaHayvan = await _hayvanGonulluApiService.GetirById(id);
            var raporlar = await _raporApiService.GetirRaporlarByHastaHayvanId(id);

            HayvanRaporDetayModel hayvanRaporDetayModel = new HayvanRaporDetayModel();

            hayvanRaporDetayModel.Raporlar = raporlar;
            hayvanRaporDetayModel.HastaHayvan = hastaHayvan;

            return View(hayvanRaporDetayModel);
        }

        public async Task<IActionResult> EkleRapor(int hastaHayvanId)
        {
            TempData["active"] = "hastaHayvan";

            var hastaHayvan = await _hayvanGonulluApiService.GetirById(hastaHayvanId);

            RaporAddModel raporAddModel = new RaporAddModel();
            raporAddModel.HastaHayvanId = hastaHayvanId;

            HayvanRaporEkleDetayModel hayvanRaporEkleDetayModel = new HayvanRaporEkleDetayModel();

            hayvanRaporEkleDetayModel.Rapor = raporAddModel;
            hayvanRaporEkleDetayModel.HastaHayvan = hastaHayvan;

            return View(hayvanRaporEkleDetayModel);
        }

        [HttpPost]
        public async Task<IActionResult> EkleRapor(HayvanRaporEkleDetayModel model)
        {
            TempData["active"] = "hastaHayvan";

            if (ModelState.IsValid)
            {
                var kullanici = _authApiService.GetirAktifKullanici();

                await _raporApiService.EkleRapor(model.Rapor.HastaHayvanId, model.Rapor);

                BildirimAddModel bildirimModel = new BildirimAddModel();
                bildirimModel.Baslik = "Rapor";
                bildirimModel.Mesaj = kullanici.KullaniciAd +" bir rapor yazdı.";
                bildirimModel.KullaniciId = 1;
                await _bildirimApiService.Ekle(bildirimModel);

                return RedirectToAction("DetayHastaHayvan", new { id = model.Rapor.HastaHayvanId });
            }
            return View(model);
        }

        public async Task<IActionResult> DetayHastaHayvan(int id)
        {
            TempData["active"] = "hastaHayvan";

            var hastaHayvan = await _hayvanGonulluApiService.GetirById(id);
            var raporlar = await _raporApiService.GetirRaporlarByHastaHayvanId(id);

            HayvanRaporDetayModel hayvanRaporDetayModel = new HayvanRaporDetayModel();

            hayvanRaporDetayModel.Raporlar = raporlar;
            hayvanRaporDetayModel.HastaHayvan = hastaHayvan;

            return View(hayvanRaporDetayModel);
        }

        public async Task<IActionResult> SilRapor(int id)
        {
            TempData["active"] = "hastaHayvan";

            var rapor = await _raporApiService.GetById(id);
            var hastaHayvan = await _hayvanGonulluApiService.GetirById(rapor.HastaHayvanId);

            await _raporApiService.SilRapor(id);
            return RedirectToAction("DetayHastaHayvan", new { id = hastaHayvan.Id });
        }
        
        public async Task<IActionResult> GuncelleRapor(int id)
        {
            TempData["active"] = "hastaHayvan";

            var rapor = await _raporApiService.GetById(id);
            var hastaHayvan = await _hayvanGonulluApiService.GetirById(rapor.HastaHayvanId);
            
            RaporUpdateModel raporModel = new RaporUpdateModel();
            raporModel.Id = rapor.Id;
            raporModel.Baslik = rapor.Baslik;
            raporModel.Detay = rapor.Detay;
            raporModel.HastaHayvanId = rapor.HastaHayvanId;

            HayvanRaporUpdateDetayModel detayModel = new HayvanRaporUpdateDetayModel();

            detayModel.Rapor = raporModel;
            detayModel.HastaHayvan = hastaHayvan;

            return View(detayModel);
        }

        [HttpPost]
        public async Task<IActionResult> GuncelleRapor(HayvanRaporUpdateDetayModel model)
        {
            TempData["active"] = "hastaHayvan";

            if (ModelState.IsValid)
            {
                var rapor = await _raporApiService.GetById(model.Rapor.Id);
                model.Rapor.HastaHayvanId = rapor.HastaHayvanId;

                await _raporApiService.GuncelleRapor(model.Rapor);
                return RedirectToAction("DetayHastaHayvan", new { id = rapor.HastaHayvanId });
            }
            return View(model);
        }

        public async Task<IActionResult> Tamamlandi(int id)
        {
            TempData["active"] = "hastaHayvan";

            await _hastaHayvanApiService.TamamlandiOlarakIsaretle(id);
            return RedirectToAction("Index");
        }
    }
}

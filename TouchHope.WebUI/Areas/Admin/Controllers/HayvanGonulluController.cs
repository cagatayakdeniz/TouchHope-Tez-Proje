using JwtProje.Business.StringInfos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Business.Abstract;
using TouchHope.WebUI.ActionFilters;
using TouchHope.WebUI.ApiServices.Abstract;
using TouchHope.WebUI.Models;

namespace TouchHope.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [JwtAuthorize(Roller = RoleInfo.Admin)]
    public class HayvanGonulluController : Controller
    {
        private IHayvanGonulluApiService _hayvanGonulluApiService;
        private IRaporApiService _raporApiService;
        private IGonulluApiService _gonulluApiService;
        private IDosyaService _dosyaService;
        private IBildirimApiService _bildirimApiService;
        public HayvanGonulluController(IHayvanGonulluApiService hayvanGonulluApiService, IRaporApiService raporApiService,
            IDosyaService dosyaService, IGonulluApiService gonulluApiService, IBildirimApiService bildirimApiService)
        {
            _bildirimApiService = bildirimApiService;
            _dosyaService = dosyaService;
            _hayvanGonulluApiService = hayvanGonulluApiService;
            _raporApiService = raporApiService;
            _gonulluApiService = gonulluApiService;
        }

        public async Task<IActionResult> Index()
        {
            TempData["active"] = "hayvangonullu";

            return View(await _hayvanGonulluApiService.GetirHepsi());
        }

        public async Task<IActionResult> GetirRaporlar(int id)
        {
            TempData["active"] = "hayvangonullu";

            var raporlar = await _raporApiService.GetirRaporlarByHastaHayvanId(id);
            var hastaHayvan = await _hayvanGonulluApiService.GetirById(id);

            HayvanRaporDetayModel hayvanRaporDetayModel = new HayvanRaporDetayModel();

            hayvanRaporDetayModel.Raporlar = raporlar;
            hayvanRaporDetayModel.HastaHayvan = hastaHayvan;

            return View(hayvanRaporDetayModel);
        }

        public async Task<IActionResult> GetirExcel(int id)
        {
            TempData["active"] = "hayvangonullu";

            var raporlar = await _raporApiService.GetirRaporlarByHastaHayvanId(id);
            var hayvan = await _hayvanGonulluApiService.GetirById(id);

            List<ExcelPdfRapor> models = new List<ExcelPdfRapor>();

            foreach (var rapor in raporlar)
            {
                ExcelPdfRapor model = new ExcelPdfRapor();
                model.Id = rapor.Id;
                model.Baslik = rapor.Baslik;
                model.Detay = rapor.Detay;
                model.HastaHayvanId = rapor.HastaHayvanId;
                model.Aciliyet = hayvan.Aciliyet.Tanim;
                model.Il = hayvan.Il.Ad;
                model.Tur = hayvan.Tur.Ad;
                model.GorevliKullaniciAd = hayvan.Kullanici.KullaniciAd;
                models.Add(model);
            }

            return File(_dosyaService.AktarExcel(models),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", Guid.NewGuid() + ".xlsx");
        }

        public async Task<IActionResult> GetirPdf(int id)
        {
            TempData["active"] = "hayvangonullu";

            var raporlar = await _raporApiService.GetirRaporlarByHastaHayvanId(id);
            var hayvan = await _hayvanGonulluApiService.GetirById(id);

            List<ExcelPdfRapor> models = new List<ExcelPdfRapor>();

            foreach (var rapor in raporlar)
            {
                ExcelPdfRapor model = new ExcelPdfRapor();
                model.Id = rapor.Id;
                model.Baslik = rapor.Baslik;
                model.Detay = rapor.Detay;
                model.HastaHayvanId = rapor.HastaHayvanId;
                model.Aciliyet = hayvan.Aciliyet.Tanim;
                model.Il = hayvan.Il.Ad;
                model.Tur = hayvan.Tur.Ad;
                model.GorevliKullaniciAd = hayvan.Kullanici.KullaniciAd;
                models.Add(model);
            }

            var path = _dosyaService.AktarPdf(models);

            return File(path, "application/pdf", Guid.NewGuid() + ".pdf");
        }

        public async Task<IActionResult> GonulluGorevlendir(int id)
        {
            TempData["active"] = "hayvangonullu";

            var hayvan = await _hayvanGonulluApiService.GetirById(id);
            var gonulluler = await _gonulluApiService.GetirHepsi();

            ViewBag.Gonullu = gonulluler;

            return View(hayvan);
        }

        public async Task<IActionResult> GorevlendirmeTamam(int hayvanId, int gonulluId)
        {
            TempData["active"] = "hayvangonullu";

            await _hayvanGonulluApiService.Gorevlendir(hayvanId, gonulluId);

            BildirimAddModel model = new BildirimAddModel();
            model.KullaniciId = gonulluId;
            model.Baslik = "Görevlendirme";
            model.Mesaj = "Hasta bir hayvan için görevlendirildiniz.";
            await _bildirimApiService.Ekle(model);

            TempData["Gorevlendir"] = "Görevlendirme İşlemi Başarılı.";

            return RedirectToAction("Index");
        }
    }
}

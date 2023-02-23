using JwtProje.Business.StringInfos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.ActionFilters;
using TouchHope.WebUI.ApiServices.Abstract;
using TouchHope.WebUI.Models;
// Çağatay Akdeniz //
namespace TouchHope.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [JwtAuthorize(Roller = RoleInfo.Admin)]
    public class TurController : Controller
    {
        private ITurApiService _turApiService;
        public TurController(ITurApiService turApiService)
        {
            _turApiService = turApiService;
        }

        public async Task<IActionResult> Index()
        {
            TempData["active"] = "tur";

            return View(await _turApiService.GetirHepsi());
        }

        public async Task<IActionResult> SilTur(int id)
        {
            TempData["active"] = "tur";

            await _turApiService.Sil(id);
            return RedirectToAction("Index");
        }

        public IActionResult EkleTur(int id)
        {
            TempData["active"] = "tur";

            return View();
        }

        public async Task<IActionResult> DuzenleTur(int id)
        {
            TempData["active"] = "tur";

            var tur = await _turApiService.GetirById(id);
            return View(new TurUpdateModel
            {
                Id= tur.Id,
                Ad= tur.Ad
            });
        }

        [HttpPost]
        public async Task<IActionResult> DuzenleTur(TurUpdateModel turUpdateModel)
        {
            TempData["active"] = "tur";

            if (ModelState.IsValid)
            {
                await _turApiService.Guncelle(turUpdateModel);
                TempData["messageGuncelle"] = "Tür Güncelleme İşlemi Başarılı.";
                return RedirectToAction("Index");
            }
            return View("DuzenleTur", turUpdateModel);
        }

        [HttpPost]
        public async Task<IActionResult> EkleTur(int id, TurAddModel turAddModel)
        {
            TempData["active"] = "tur";

            if (ModelState.IsValid)
            {
                await _turApiService.Ekle(turAddModel);

                TempData["message"] = "Tür Ekleme İşlemi Başarılı.";
                return RedirectToAction("Index");
            }
            return View("EkleTur", turAddModel);
        }
    }
}

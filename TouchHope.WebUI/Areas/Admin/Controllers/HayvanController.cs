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
    public class HayvanController : Controller
    {
        private IHayvanApiService _hayvanApiService;
        public HayvanController(IHayvanApiService hayvanApiService)
        {
            _hayvanApiService = hayvanApiService;
        }

        public async Task<IActionResult> KaybolanHayvan()
        {
            TempData["active"] = "hayvan";

            return View(await _hayvanApiService.GetirHepsiKaybolanHayvanlar());
        }

        public async Task<IActionResult> SahiplendirilecekHayvan()
        {
            TempData["active"] = "hayvan";

            return View(await _hayvanApiService.GetirHepsiSahiplendirilecekHayvanlar());
        }

        public async Task<IActionResult> SilSahiplendirilecekHayvan(int id)
        {
            TempData["active"] = "hayvan";

            await _hayvanApiService.SilSahiplendirilecek(id);
            return RedirectToAction("SahiplendirilecekHayvan");
        }

        public async Task<IActionResult> SilKaybolanHayvan(int id)
        {
            TempData["active"] = "hayvan";

            await _hayvanApiService.SilKaybolan(id);
            return RedirectToAction("KaybolanHayvan");
        }
    }
}

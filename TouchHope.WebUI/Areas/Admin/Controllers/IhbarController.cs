using JwtProje.Business.StringInfos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.ActionFilters;
using TouchHope.WebUI.ApiServices.Abstract;

namespace TouchHope.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [JwtAuthorize(Roller = RoleInfo.Admin)]
    public class IhbarController : Controller
    {
        private IIhbarApiService _ihbarApiService;
        public IhbarController(IIhbarApiService ihbarApiService)
        {
            _ihbarApiService = ihbarApiService;
        }

        public async Task<IActionResult> Index()// Çağatay Akdeniz //
        {
            TempData["active"] = "ihbar";

            return View(await _ihbarApiService.GetirHepsi());
        }

        public async Task<IActionResult> OnaylaIhbar(int id)
        {
            TempData["active"] = "ihbar";

            await _ihbarApiService.Onayla(id);

            TempData["ihbarOnaylandi"] = "İhbar Onaylama İşlemi Başarılı";// Çağatay Akdeniz //

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> SilIhbar(int id)
        {
            TempData["active"] = "ihbar";

            await _ihbarApiService.Sil(id);
            return RedirectToAction("Index");
        }
    }
}
// Çağatay Akdeniz //
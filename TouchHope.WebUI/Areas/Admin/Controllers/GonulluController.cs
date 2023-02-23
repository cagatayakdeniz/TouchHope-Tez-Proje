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

namespace TouchHope.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [JwtAuthorize(Roller = RoleInfo.Admin)]
    public class GonulluController : Controller
    {
        private IGonulluApiService _gonulluApiService;
        private IBildirimApiService _bildirimApiService;
        public GonulluController(IGonulluApiService gonulluApiService, IBildirimApiService bildirimApiService)
        {
            _gonulluApiService = gonulluApiService;
            _bildirimApiService = bildirimApiService;
        }

        public async Task<IActionResult> Index()
        {
            TempData["active"] = "gonullu";

            return View(await _gonulluApiService.GetirHepsi());
        }

        public async Task<IActionResult> SilGonullu(int id)
        {
            TempData["active"] = "gonullu";

            await _gonulluApiService.Sil(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> GonulluyeMesaj()
        {
            TempData["active"] = "gonullu";

            ViewBag.Gonulluler = new SelectList(await _gonulluApiService.GetirHepsi(),"Id","Ad");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GonulluyeMesaj(BildirimAddModel bildirimAddModel)
        {
            TempData["active"] = "gonullu";

            if (ModelState.IsValid)
            {
                await _bildirimApiService.Ekle(bildirimAddModel);

                TempData["message"] = "Mesaj Gönderildi.";

                return RedirectToAction("GonulluyeMesaj");
            }
            return View("GonulluyeMesaj", bildirimAddModel);
        }
    }
}

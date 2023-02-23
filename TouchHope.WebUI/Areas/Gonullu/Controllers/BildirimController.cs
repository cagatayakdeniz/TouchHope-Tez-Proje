using JwtProje.Business.StringInfos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.ActionFilters;
using TouchHope.WebUI.ApiServices.Abstract;

namespace TouchHope.WebUI.Areas.Gonullu.Controllers
{
    [Area("Gonullu")]
    [JwtAuthorize(Roller = RoleInfo.Gonullu)]
    public class BildirimController : Controller
    {
        private IAuthApiService _authApiService;
        private IBildirimApiService _bildirimApiService;
        public BildirimController(IBildirimApiService bildirimApiService, IAuthApiService authApiService)
        {
            _authApiService = authApiService;
            _bildirimApiService = bildirimApiService;
        }

        public async Task<IActionResult> Index()
        {
            TempData["active"] = "bildirim";

            var gonullu = _authApiService.GetirAktifKullanici();
            return View(await _bildirimApiService.GetirOkunmayanlar(gonullu.Id));
        }

        public async Task<IActionResult> Okundu(int id)
        {
            TempData["active"] = "bildirim";

            await _bildirimApiService.OkuBildirim(id);
            return RedirectToAction("Index");
        }
    }
}
// Çağatay Akdeniz //
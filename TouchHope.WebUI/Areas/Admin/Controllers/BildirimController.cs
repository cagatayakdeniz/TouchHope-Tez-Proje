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
    public class BildirimController : Controller
    {
        private IBildirimApiService _bildirimApiService;
        private IAuthApiService _authApiService;
        public BildirimController(IBildirimApiService bildirimApiService, IAuthApiService authApiService)
        {
            _bildirimApiService = bildirimApiService;
            _authApiService = authApiService;
        }

        public async Task<IActionResult> Index()
        {
            TempData["active"] = "bildirim";

            var kullanici = _authApiService.GetirAktifKullanici();

            return View(await _bildirimApiService.GetirOkunmayanlar(kullanici.Id));
        }

        public async Task<IActionResult> OkuBildirim(int id)
        {
            TempData["active"] = "bildirim";
           
            await _bildirimApiService.OkuBildirim(id);
            TempData["bildirimOkundu"] = "Bildirim okundu";
            return Json(true);
        }
    }
}

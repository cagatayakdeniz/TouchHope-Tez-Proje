using JwtProje.Business.StringInfos;
using Microsoft.AspNetCore.Mvc;
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
    public class HastaHayvanController : Controller
    {
        private IHayvanGonulluApiService _hayvanGonulluApiService;
        private IHastaHayvanApiService _hastaHayvanApiService;
        private IRaporApiService _raporApiService;
        public HastaHayvanController(IHastaHayvanApiService hastaHayvanApiService, IRaporApiService raporApiService,
            IHayvanGonulluApiService hayvanGonulluApiService)
        {
            _hayvanGonulluApiService = hayvanGonulluApiService;
            _raporApiService = raporApiService;
            _hastaHayvanApiService = hastaHayvanApiService;
        }

        public async Task<IActionResult> Index()
        {
            TempData["active"] = "hastahayvan";

            return View(await _hastaHayvanApiService.GetirHepsi());
        }

        public async Task<IActionResult> IyilesenHayvan()
        {
            TempData["active"] = "hastahayvan";

            return View(await _hastaHayvanApiService.GetirIyilesenHayvanlar());
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
    }
}

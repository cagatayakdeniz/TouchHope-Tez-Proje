using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.ApiServices.Abstract;

namespace TouchHope.WebUI.ViewComponents
{
    public class IhbarEkle : ViewComponent
    {
        private IHayvanApiService _hayvanApiService;
        private IIlApiService _ilApiService;
        private ITurApiService _turApiService;
        private IAciliyetApiService _aciliyetApiService;
        public IhbarEkle(IHayvanApiService hayvanApiService, IIlApiService ilApiService, ITurApiService turApiService, IAciliyetApiService aciliyetApiService)
        {
            _aciliyetApiService = aciliyetApiService;
            _hayvanApiService = hayvanApiService;
            _turApiService = turApiService;
            _ilApiService = ilApiService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Iller = new SelectList(_ilApiService.GetirHepsi().Result, "Id", "Ad");
            ViewBag.Turler = new SelectList(_turApiService.GetirHepsi().Result, "Id", "Ad");
            ViewBag.Aciliyetler = new SelectList(_aciliyetApiService.GetirHepsi().Result, "Id", "Tanim");

            return View();
        }
    }
}

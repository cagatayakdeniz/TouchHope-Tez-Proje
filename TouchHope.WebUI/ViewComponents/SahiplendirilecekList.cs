using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.WebUI.ApiServices.Abstract;

namespace TouchHope.WebUI.ViewComponents
{
    public class SahiplendirilecekList : ViewComponent
    {
        private IHayvanApiService _hayvanApiService;
        public SahiplendirilecekList(IHayvanApiService hayvanApiService)
        {
            _hayvanApiService = hayvanApiService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_hayvanApiService.GetirHepsiSahiplendirilecekHayvanlar().Result);
        }
    }
}

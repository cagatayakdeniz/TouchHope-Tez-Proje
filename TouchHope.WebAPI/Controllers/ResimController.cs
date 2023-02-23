using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Business.Abstract;

namespace TouchHope.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResimController : ControllerBase
    {
        private IIhbarService _ihbarService;
        private IHastaHayvanService _hastaHayvanService;
        private IKaybolanHayvanService _kaybolanHayvanService;
        private ISahiplendirilecekHayvanService _sahiplendirilecekHayvanService;
        public ResimController(IIhbarService ihbarService, IHastaHayvanService hastaHayvanService, IKaybolanHayvanService kaybolanHayvanService
            ,ISahiplendirilecekHayvanService sahiplendirilecekHayvanService)
        {
            _ihbarService = ihbarService;
            _hastaHayvanService = hastaHayvanService;
            _kaybolanHayvanService = kaybolanHayvanService;
            _sahiplendirilecekHayvanService = sahiplendirilecekHayvanService;
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetIhbarResimById(int id)
        {
            var ihbar = await _ihbarService.FindByIdAsync(id);
            if (string.IsNullOrEmpty(ihbar.FotografUrl))
            {
                return BadRequest("Resim Yok.");
            }
            return File($"img/{ihbar.FotografUrl}", "image/jpeg");
        }
        // Çağatay Akdeniz //
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetHastaHayvanResimById(int id)
        {
            var hastaHayvan = await _hastaHayvanService.FindByIdAsync(id);// Çağatay Akdeniz //
            if (string.IsNullOrEmpty(hastaHayvan.FotografUrl))
            {
                return BadRequest("Resim Yok.");
            }
            return File($"img/{hastaHayvan.FotografUrl}", "image/jpeg");
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetKaybolanHayvanResimById(int id)
        {
            var kaybolanHayvan = await _kaybolanHayvanService.FindByIdAsync(id);
            if (string.IsNullOrEmpty(kaybolanHayvan.FotografUrl))
            {
                return BadRequest("Resim Yok.");
            }
            return File($"img/{kaybolanHayvan.FotografUrl}", "image/jpeg");
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetSahiplendirilecekHayvanResimById(int id)
        {
            var sahiplendirilecekHayvan = await _sahiplendirilecekHayvanService.FindByIdAsync(id);
            if (string.IsNullOrEmpty(sahiplendirilecekHayvan.FotografUrl))
            {
                return BadRequest("Resim Yok.");
            }
            return File($"img/{sahiplendirilecekHayvan.FotografUrl}", "image/jpeg");
        }
    }
}
// Çağatay Akdeniz //
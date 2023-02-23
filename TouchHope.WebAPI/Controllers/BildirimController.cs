using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Business.Abstract;
using TouchHope.Entities.Concrete;
using TouchHope.Entities.Dtos;

namespace TouchHope.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BildirimController : ControllerBase
    {
        private IMapper _mapper;
        private IBildirimService _bildirimService;
        private IKullaniciService _kullaniciService;
        public BildirimController(IMapper mapper, IBildirimService bildirimService, IKullaniciService kullaniciService)
        {
            _mapper = mapper;
            _kullaniciService = kullaniciService;
            _bildirimService = bildirimService;
        }

        [HttpGet("[action]/{id}")]
        [Authorize]
        public async Task<IActionResult> GetirBildirimlerListe(int id)
        {
            return Ok(_mapper.Map<List<BildirimListDto>>(await _bildirimService.GetirOkunmamisBildirimListe(id)));
        }

        [HttpGet("[action]/{id}")]
        [Authorize]
        public async Task<IActionResult> GetirBildirimSayisi(int id)
        {
            var bildirimSayisi = await _bildirimService.GetirOkunmamisBildirimSayisi(id);
            return Ok(bildirimSayisi);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EkleBildirim(BildirimAddDto bildirimAddDto)
        {
            await _bildirimService.AddAsync(_mapper.Map<Bildirim>(bildirimAddDto));
            return Ok(bildirimAddDto);
        }

        [HttpGet("[action]/{id}")]
        [Authorize]
        public async Task<IActionResult> OkuBildirim(int id)
        {
            var bildirim = await _bildirimService.FindByIdAsync(id);
            bildirim.Durum = true;
            await _bildirimService.UpdateAsync(bildirim);
            return NoContent();
        }
    }
}

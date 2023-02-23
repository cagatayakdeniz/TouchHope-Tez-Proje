using AutoMapper;
using JwtProje.Business.StringInfos;
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
    public class HastaHayvanController : ControllerBase
    {
        private IMapper _mapper;
        private IHastaHayvanService _hastaHayvanService;
        private IKullaniciService _kullaniciService;

        public HastaHayvanController(IMapper mapper, IHastaHayvanService hastaHayvanService, IKullaniciService kullaniciService)
        {
            _mapper = mapper;
            _hastaHayvanService = hastaHayvanService;
            _kullaniciService = kullaniciService;
        }

        //908.386
        //296
        [HttpGet]
        //[Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirHepsi()
        {            
            return Ok(_mapper.Map<List<HastaHayvanListDto>>(await _hastaHayvanService.GetirTumTablolarla()));
        }

        //5.607
        //127
        [HttpGet("[action]")]
        //[Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirHastaHayvanlar()
        {
            return Ok(_mapper.Map<List<HastaHayvanListDto>>(await _hastaHayvanService.GetirTablolarlaList()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetirById(int id)
        {
            return Ok(_mapper.Map<HastaHayvanListDto>(await _hastaHayvanService.GetirByIdTumTablolarla(id)));
        }

        [HttpGet("[action]")]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirTamamlananHayvanlar()
        {
            return Ok(_mapper.Map<List<HastaHayvanListDto>>(await _hastaHayvanService.GetirTamamlananTumTablolarla()));
        }

        [HttpGet("[action]")]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirHastaHayvanSayisi()
        {
            return Ok(await _hastaHayvanService.GetirHastaHayvanSayisi());
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetirIyilesenHayvanSayisi()
        {
            return Ok(await _hastaHayvanService.GetirIyilesenHayvanSayisi());
        }

        [HttpGet("[action]/{id}")]
        [Authorize(Roles = RoleInfo.Gonullu)]
        public async Task<IActionResult> GetirAktifGorevlendirildigimHayvanSayisi(int id)
        {
            return Ok(await _hastaHayvanService.AktifGorevHastaHayvanSayisi(id));
        }

        [HttpGet("[action]/{id}")]
        [Authorize(Roles = RoleInfo.Gonullu)]
        public async Task<IActionResult> GetirIyilestirdigimHayvanSayisi(int id)
        {
            return Ok(await _hastaHayvanService.IyilestirilenHastaHayvanSayisi(id));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Ara([FromQuery] string s)
        {
            var searchBlogs = await _hastaHayvanService.Ara(s);
            if (searchBlogs == null)
            {
                return NotFound("Hasta Hayvan Bulunamadı");
            }
            return Ok(_mapper.Map<List<HastaHayvanListDto>>(searchBlogs));
        }

        [HttpGet("[action]/{id}")]
        [Authorize(Roles = RoleInfo.Gonullu)]
        public async Task<IActionResult> TamamlandiOlarakIsaretle(int id)
        {
            var hastaHayvan = await _hastaHayvanService.FindByIdAsync(id);
            hastaHayvan.Durum = true;
            await _hastaHayvanService.UpdateAsync(hastaHayvan);
            return NoContent();
        }

        [HttpGet("[action]")]
        [Authorize(Roles = RoleInfo.Admin)]
        //public async Task<IActionResult> GonulluAta(int hayvanId, int gonulluId)
        //{
        //    var hastaHayvan = await _hastaHayvanService.FindByIdAsync(hayvanId);
        //    //var gonullu = await _kullaniciService.FindByIdAsync(gonulluId);

        //    hastaHayvan.KullaniciId = gonullu.Id;

        //    await _hastaHayvanService.UpdateAsync(hastaHayvan);

        //    return NoContent();
        //}

        [HttpGet("[action]/{gonulluId}")]
        [Authorize(Roles = RoleInfo.Gonullu)]
        public async Task<IActionResult> GetirGorevliHastaHayvanlar(int gonulluId)
        {
            return Ok(_mapper.Map<List<HastaHayvanListDto>>(await _hastaHayvanService.GetirGorevliHastaHayvanlar(gonulluId)));
        }

        [HttpGet("[action]/{gonulluId}")]
        [Authorize(Roles = RoleInfo.Gonullu)]
        public async Task<IActionResult> GetirTamamlananHastaHayvanlar(int gonulluId)
        {
            return Ok(_mapper.Map<List<HastaHayvanListDto>>(await _hastaHayvanService.GetirTamamlananHastaHayvanlarById(gonulluId)));
        }

        [HttpGet("[action]")]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirAktifIlgilenilenHayvanSayisi()
        {
            return Ok(await _hastaHayvanService.GetirAktifIlgilenilenHayvanSayisi());
        }

        [HttpGet("[action]")]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirAtanmayıBekleyenHayvanSayisi()
        {
            return Ok(await _hastaHayvanService.GetirAtanmayıBekleyenHayvanSayisi());
        }
    }
}

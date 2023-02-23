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
    public class KullaniciController : ControllerBase
    {
        private IMapper _mapper;
        private IKullaniciService _kullaniciService;
        private IRolService _rolService;
        private IKullaniciRolService _kullaniciRolService;
        private ICinsiyetService _cinsiyetService;
        private IIlService _ilService;
        public KullaniciController(IKullaniciService kullaniciService, IMapper mapper, ICinsiyetService cinsiyetService,
            IIlService ilService, IRolService rolService, IKullaniciRolService kullaniciRolService)
        {
            _mapper = mapper;
            _ilService = ilService;
            _kullaniciService = kullaniciService;
            _cinsiyetService = cinsiyetService;
            _rolService = rolService;
            _kullaniciRolService = kullaniciRolService;
        }

        [HttpGet("[action]")]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirGonulluSayisi()
        {
            var gonulluSayisi = await _kullaniciService.GetirGonulluSayisi(RoleInfo.Gonullu);

            return Ok(gonulluSayisi);
        }

        [HttpGet]
        //[Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirGonulluListe()
        {
            return Ok(_mapper.Map<List<KullaniciListDto>>(await _kullaniciService.GetirGonulluListe(RoleInfo.Gonullu)));
        }

        [HttpGet("{id}")]
        [Authorize(Roles = RoleInfo.Gonullu)]
        //public async Task<IActionResult> GetirById(int id)
        //{
        //    return Ok(_mapper.Map<KullaniciListDto>(await _kullaniciService.FindByIdAsync(id)));
        //}

        [HttpDelete("{id}")]
        [Authorize(Roles = RoleInfo.Admin)]
        //public async Task<IActionResult> SilGonullu(int id)
        //{
        //    var gonullu = await _kullaniciService.FindByIdAsync(id);

        //    await _kullaniciService.DeleteAsync(gonullu);
        //    return NoContent();
        //}

        [HttpGet("[action]")]
        public async Task<IActionResult> GetirGonulluListeByErkek()
        {
            var cinsiyet = await _cinsiyetService.FindByIdAsync(1);
            return Ok(_mapper.Map<List<KullaniciListDto>>(await _kullaniciService.GetirGonulluListeByErkek(RoleInfo.Gonullu, cinsiyet.Ad)));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetirGonulluListeByKadin()
        {
            var cinsiyet = await _cinsiyetService.FindByIdAsync(2);
            return Ok(_mapper.Map<List<KullaniciListDto>>(await _kullaniciService.GetirGonulluListeByErkek(RoleInfo.Gonullu, cinsiyet.Ad)));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetirGonulluErkekSayisi()
        {
            var cinsiyet = await _cinsiyetService.FindByIdAsync(1);
            return Ok(await _kullaniciService.GetirGonulluErkekSayisi(RoleInfo.Gonullu, cinsiyet.Ad));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetirGonulluKadinSayisi()
        {
            var cinsiyet = await _cinsiyetService.FindByIdAsync(2);
            return Ok(await _kullaniciService.GetirGonulluKadinSayisi(RoleInfo.Gonullu, cinsiyet.Ad));
        }

        [HttpGet("[action]/{sehirId}")]
        public async Task<IActionResult> GetirGonulluListesiBySehirId(int sehirId)
        {
            return Ok(_mapper.Map<List<KullaniciListDto>>(await _kullaniciService.GetirGonulluListeBySehir(RoleInfo.Gonullu, sehirId)));
        }

        [HttpGet("[action]/{sehirId}")]
        public async Task<IActionResult> GetirGonulluErkekListesiBySehirId(int sehirId)
        {
            var cinsiyet = await _cinsiyetService.FindByIdAsync(1);
            return Ok(_mapper.Map<List<KullaniciListDto>>(await _kullaniciService.GetirGonulluErkekListesiBySehirId(RoleInfo.Gonullu, cinsiyet.Id, sehirId)));
        }

        [HttpGet("[action]/{sehirId}")]
        public async Task<IActionResult> GetirGonulluKadinListesiBySehirId(int sehirId)
        {
            var cinsiyet = await _cinsiyetService.FindByIdAsync(2);
            return Ok(_mapper.Map<List<KullaniciListDto>>(await _kullaniciService.GetirGonulluKadinListesiBySehirId(RoleInfo.Gonullu, cinsiyet.Id, sehirId)));
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> GuncelleProfil(int id, KullaniciUpdateDto kullaniciUpdateDto)
        //{
        //    await _kullaniciService.UpdateAsync(_mapper.Map<Kullanici>(kullaniciUpdateDto));
        //    return NoContent();
        //}
    }
}

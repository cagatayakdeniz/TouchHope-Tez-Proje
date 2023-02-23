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
    public class RaporController : ControllerBase
    {
        private IMapper _mapper;
        private IRaporService _raporService;
        public RaporController(IMapper mapper, IRaporService raporService)
        {
            _mapper = mapper;
            _raporService = raporService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetirRaporSayisi()
        {
            return Ok(await _raporService.GetirRaporSayisi());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetirRaporById(int id)
        {
            return Ok(_mapper.Map<RaporListDto>(await _raporService.FindByIdAsync(id)));
        }

        [HttpPost("[action]/{hastaHayvanId}")]
        [Authorize(Roles = RoleInfo.Gonullu)]
        public async Task<IActionResult> RaporYaz(int hastaHayvanId, RaporAddDto raporAddDto)
        {
            raporAddDto.HastaHayvanId = hastaHayvanId;
            await _raporService.AddAsync(_mapper.Map<Rapor>(raporAddDto));
            return Ok(raporAddDto);
        }

        [HttpGet("[action]/{hastaHayvanId}")]
        public async Task<IActionResult> GetirRaporlarByHayvanId(int hastaHayvanId)
        {
            return Ok(_mapper.Map<List<RaporListDto>>(await _raporService.GetirRaporlarByHayvanId(hastaHayvanId)));
        }

        [HttpGet("[action]/{id}")]
        [Authorize(Roles = RoleInfo.Gonullu)]
        public async Task<IActionResult> GetirYazdigimRaporSayisi(int id)
        {
            return Ok(await _raporService.GetirYazdigimRaporSayisi(id));
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = RoleInfo.Gonullu)]
        public async Task<IActionResult> Sil(int id)
        {
            var rapor = await _raporService.FindByIdAsync(id);
            await _raporService.DeleteAsync(rapor);
            return NoContent();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = RoleInfo.Gonullu)]
        public async Task<IActionResult> Guncelle(int id, RaporUpdateDto raporUpdateDto)
        {
            var rapor = await _raporService.FindByIdAsync(id);
            raporUpdateDto.Id = rapor.Id;
            raporUpdateDto.HastaHayvanId = rapor.HastaHayvanId;

            await _raporService.UpdateAsync(_mapper.Map<Rapor>(raporUpdateDto));
            return NoContent();
        }
    }
}

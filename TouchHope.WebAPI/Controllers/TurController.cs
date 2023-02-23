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
    public class TurController : ControllerBase
    {
        private IMapper _mapper;
        private ITurService _turService;
        public TurController(IMapper mapper, ITurService turService)
        {
            _mapper = mapper;
            _turService = turService;
        }

        [HttpGet] 
        public async Task<IActionResult> GetirHepsi()
        {
            return Ok(_mapper.Map<List<TurListDto>>(await _turService.GetAllAsync()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetirById(int id)
        {
            var tur = await _turService.FindByIdAsync(id);
            return Ok(_mapper.Map<TurListDto>(tur));
        }

        [HttpPost]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> EkleTur(TurAddDto turAddDto)
        {
            await _turService.AddAsync(_mapper.Map<Tur>(turAddDto));
            return Created("", turAddDto);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GuncelleTur(int id, TurUpdateDto turUpdateDto)
        {
            if (id != turUpdateDto.Id)
            {
                return BadRequest("Geçersiz Id");
            }
            await _turService.UpdateAsync(_mapper.Map<Tur>(turUpdateDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> SilTur(int id)
        {
            var tur = await _turService.FindByIdAsync(id);
            await _turService.DeleteAsync(tur);
            return NoContent();
        }
    }
}

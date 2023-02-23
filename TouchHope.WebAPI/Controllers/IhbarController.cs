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
using TouchHope.WebApi.Controllers;
using TouchHope.WebAPI.Enums;

namespace TouchHope.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IhbarController : BaseController
    {
        private IMapper _mapper;
        private IIhbarService _ihbarService;
        private IHastaHayvanService _hastaHayvanService;
        public IhbarController(IMapper mapper, IIhbarService ihbarService, IHastaHayvanService hastaHayvanService)
        {
            _mapper = mapper;
            _ihbarService = ihbarService;
            _hastaHayvanService = hastaHayvanService;
        }

        [HttpGet]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirHepsi()
        {
            return Ok(_mapper.Map<List<IhbarListDto>>(await _ihbarService.GetirHepsiTumTablolarla()));
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> EkleIhbar([FromForm] IhbarAddDto ihbarAddDto)
        {
            string[] resimUzantilari = new string[] { "image/bmp", "image/jpeg", "image/gif", "image/png" };
            string dosyaTuru = ihbarAddDto.Fotograf.ContentType;// Çağatay Akdeniz //
            foreach (string u in resimUzantilari)
            {
                if (dosyaTuru == u)
                {
                    var uploadModel = await UploadFileAsync(ihbarAddDto.Fotograf, u);
                    if (uploadModel.UploadState == UploadState.Success)
                    {
                        ihbarAddDto.FotografUrl = uploadModel.newName;
                        await _ihbarService.AddAsync(_mapper.Map<Ihbar>(ihbarAddDto));
                        return Created("", ihbarAddDto);
                    }
                    else if (uploadModel.UploadState == UploadState.NotExist)
                    {
                        await _ihbarService.AddAsync(_mapper.Map<Ihbar>(ihbarAddDto));
                        return Created("", ihbarAddDto);
                    }
                    else
                    {
                        return BadRequest(uploadModel.ErrorMessage);
                    }
                }
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> SilIhbar(int id)
        {
            var ihbar = await _ihbarService.FindByIdAsync(id);
            await _ihbarService.DeleteAsync(ihbar);
             
            return NoContent();
        }

        [HttpGet("[action]")]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirIhbarSayisi()
        {
            return Ok(await _ihbarService.GetirIhbarSayisi());
        }

        [HttpGet("{id}")]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirIhbarById(int id)
        {
            return Ok(_mapper.Map<IhbarListDto>(await _ihbarService.FindByIdWithTablolar(id)));
        }

        [HttpGet("[action]/{id}")]
        [Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> IhbarOnayla(int id)
        {
            var ihbar = await _ihbarService.FindByIdWithTablolar(id);
            // Çağatay Akdeniz //
            HastaHayvanAddDto hastaHayvanAddDto = new HastaHayvanAddDto();
            hastaHayvanAddDto.FotografUrl = ihbar.FotografUrl;
            hastaHayvanAddDto.Aciklama = ihbar.Aciklama;
            hastaHayvanAddDto.OlusturulmaTarih = ihbar.OlusturulmaTarih;
            hastaHayvanAddDto.AcikAdres = ihbar.AcikAdres;
            hastaHayvanAddDto.AciliyetId = ihbar.AciliyetId;
            hastaHayvanAddDto.TurId = ihbar.TurId;
            hastaHayvanAddDto.IlId = ihbar.IlId;

            await _ihbarService.DeleteAsync(ihbar);

            await _hastaHayvanService.AddAsync(_mapper.Map<HastaHayvan>(hastaHayvanAddDto));

            return Ok(hastaHayvanAddDto);
        }
    }
}
// Çağatay Akdeniz //
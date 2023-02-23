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
    public class KaybolanHayvanController : BaseController
    {
        private IMapper _mapper;
        private IKaybolanHayvanService _kaybolanHayvanService;
        public KaybolanHayvanController(IMapper mapper, IKaybolanHayvanService kaybolanHayvanService)
        {
            _mapper = mapper;
            _kaybolanHayvanService = kaybolanHayvanService;
        }

        [HttpGet]
        public async Task<IActionResult> GetirHepsi()
        {
            return Ok(_mapper.Map<List<KaybolanHayvanListDto>>(await _kaybolanHayvanService.GetirTumTablolarla()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetirToplamSayi()
        {
            return Ok(await _kaybolanHayvanService.GetirToplamSayi());
        }

        [HttpPost]
        public async Task<IActionResult> EkleKaybolanHayvan([FromForm] KaybolanHayvanAddDto kaybolanHayvanAddDto)
        {
            string[] resimUzantilari = new string[] { "image/bmp", "image/jpeg", "image/gif", "image/png" };
            string dosyaTuru = kaybolanHayvanAddDto.Fotograf.ContentType;
            foreach (string u in resimUzantilari)
            {
                if (dosyaTuru == u)
                {
                    var uploadModel = await UploadFileAsync(kaybolanHayvanAddDto.Fotograf, u);
                    if (uploadModel.UploadState == UploadState.Success)
                    {
                        kaybolanHayvanAddDto.FotografUrl = uploadModel.newName;
                        await _kaybolanHayvanService.AddAsync(_mapper.Map<KaybolanHayvan>(kaybolanHayvanAddDto));
                        return Created("", kaybolanHayvanAddDto);
                    }
                    else if (uploadModel.UploadState == UploadState.NotExist)
                    {
                        await _kaybolanHayvanService.AddAsync(_mapper.Map<KaybolanHayvan>(kaybolanHayvanAddDto));
                        return Created("", kaybolanHayvanAddDto);
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
        public async Task<IActionResult> SilKaybolanHayvan(int id)
        {
            var hayvan = await _kaybolanHayvanService.FindByIdAsync(id);

            await _kaybolanHayvanService.DeleteAsync(hayvan);

            return NoContent();
        }

        [HttpGet("[action]/{id}")]
        //[Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirSehireGore(int id)
        {
            var hayvanlar = _mapper.Map<List<KaybolanHayvanListDto>>(await _kaybolanHayvanService.GetirSehireGore(id));

            return Ok(hayvanlar);
        }
    }
}

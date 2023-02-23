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
    public class SahiplendirilecekHayvanController : BaseController
    {
        private IMapper _mapper;
        private ISahiplendirilecekHayvanService _sahiplendirilecekHayvanService;
        public SahiplendirilecekHayvanController(IMapper mapper, ISahiplendirilecekHayvanService sahiplendirilecekHayvanService)
        {
            _mapper = mapper;
            _sahiplendirilecekHayvanService = sahiplendirilecekHayvanService;
        }

        [HttpGet]
        public async Task<IActionResult> GetirHepsi()
        {
            return Ok(_mapper.Map<List<SahiplendirilecekHayvanListDto>>(await _sahiplendirilecekHayvanService.GetirTumTablolarla()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetirToplamSayi()
        {
            return Ok(await _sahiplendirilecekHayvanService.GetirToplamSayi());
        }

        [HttpPost]
        public async Task<IActionResult> EkleSahiplendirilecekHayvan([FromForm] SahiplendirilecekHayvanAddDto sahiplendirilecekHayvanAddDto)
        {
            string[] resimUzantilari = new string[] { "image/bmp", "image/jpeg", "image/gif", "image/png" };
            string dosyaTuru = sahiplendirilecekHayvanAddDto.Fotograf.ContentType;
            foreach (string u in resimUzantilari)
            {
                if (dosyaTuru == u)
                {
                    var uploadModel = await UploadFileAsync(sahiplendirilecekHayvanAddDto.Fotograf, u);
                    if (uploadModel.UploadState == UploadState.Success)
                    {
                        sahiplendirilecekHayvanAddDto.FotografUrl = uploadModel.newName;
                        await _sahiplendirilecekHayvanService.AddAsync(_mapper.Map<SahiplendirilecekHayvan>(sahiplendirilecekHayvanAddDto));
                        return Created("", sahiplendirilecekHayvanAddDto);
                    }
                    else if (uploadModel.UploadState == UploadState.NotExist)
                    {
                        await _sahiplendirilecekHayvanService.AddAsync(_mapper.Map<SahiplendirilecekHayvan>(sahiplendirilecekHayvanAddDto));
                        return Created("", sahiplendirilecekHayvanAddDto);
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
        public async Task<IActionResult> SilSahiplendirilecekHayvan(int id)
        {
            var hayvan = await _sahiplendirilecekHayvanService.FindByIdAsync(id);

            await _sahiplendirilecekHayvanService.DeleteAsync(hayvan);

            return NoContent();
        }

        [HttpGet("[action]/{id}")]
        //[Authorize(Roles = RoleInfo.Admin)]
        public async Task<IActionResult> GetirSehireGore(int id)
        {
            var hayvanlar = _mapper.Map<List<SahiplendirilecekHayvanListDto>>(await _sahiplendirilecekHayvanService.GetirSehireGore(id));

            return Ok(hayvanlar);
        }
    }
}

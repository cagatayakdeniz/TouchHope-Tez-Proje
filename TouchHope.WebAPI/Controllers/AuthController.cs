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
using TouchHope.Business.Utilities.Jwt;
using TouchHope.Business.ValidationRules;
using TouchHope.Core.CrossCuttingConcerns.Validation;
using TouchHope.Entities.Concrete;
using TouchHope.Entities.Dtos;

namespace TouchHope.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IKullaniciService _kullaniciService;
        private IJwtService _jwtService;
        private IMapper _mapper;
        public AuthController(IKullaniciService kullaniciService, IMapper mapper, IRolService rolService, IKullaniciRolService kullaniciRolService,
            IJwtService jwtService)
        {
            _mapper = mapper;
            _jwtService = jwtService;
            _kullaniciService = kullaniciService;
        }

        [HttpPost("[action]")]
        //[ValidModel]
        public async Task<IActionResult> KayitOl(KullaniciSignUpDto kullaniciSignUpDto, [FromServices] IKullaniciRolService kullaniciRolService,
            [FromServices] IRolService rolService)
        {
            var kullaniciTest = await _kullaniciService.GetirKullaniciAd(kullaniciSignUpDto.KullaniciAd);

            if (kullaniciTest != null)
            {
                return BadRequest("Bu kullanıcı adı kullanılıyor.");
            }
            
            await _kullaniciService.AddAsync(_mapper.Map<Kullanici>(kullaniciSignUpDto));

            var kullanici = await _kullaniciService.GetirKullaniciAd(kullaniciSignUpDto.KullaniciAd);
            var rol = await rolService.GetirRolAd(RoleInfo.Gonullu);

            await kullaniciRolService.AddAsync(new KullaniciRol
            {
                KullaniciId = kullanici.Id,
                RolId = rol.Id
            });

            return Created("", kullaniciSignUpDto);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SignIn(KullaniciSignInDto kullaniciSignInDto)
        {
            var kullanici = await _kullaniciService.GetirKullaniciAd(kullaniciSignInDto.KullaniciAd);
            if(kullanici==null)
            {
                return BadRequest("Kullanıcı adı bulunamadı!");
            }
            else
            {
                if(await _kullaniciService.GirisYap(kullaniciSignInDto.KullaniciAd, kullaniciSignInDto.Sifre))
                {
                    var roller = await _kullaniciService.GetirRoller(kullaniciSignInDto.KullaniciAd);
                    var token = _jwtService.GenerateToken(kullanici, roller);
                    return Created("", token);
                }
                return BadRequest("Şifre hatalı!");
            }
        }

        [HttpPut("{id}")]
        [Authorize(Roles = RoleInfo.Gonullu)]
        public async Task<IActionResult> GuncelleProfil(KullaniciUpdateDto kullaniciUpdateDto)
        {
            var kullanici = await _kullaniciService.GetirKullaniciAd(User.Identity.Name);

            kullaniciUpdateDto.Id = kullanici.Id;
            kullaniciUpdateDto.KullaniciAd = kullanici.KullaniciAd;
            kullaniciUpdateDto.Sifre = kullanici.Sifre;
            kullaniciUpdateDto.DogumTarih = kullanici.DogumTarih;

            //await _kullaniciService.UpdateAsync(_mapper.Map<Kullanici>(kullaniciUpdateDto));

            return NoContent();
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> AktifKullanici()
        {
            var kullanici = await _kullaniciService.GetirKullaniciAd(User.Identity.Name);
            var roller = await _kullaniciService.GetirRoller(User.Identity.Name);

            KullaniciDto kullaniciDto = new KullaniciDto
            {
                Id = kullanici.Id,
                KullaniciAd = kullanici.KullaniciAd,
                Ad = kullanici.Ad,
                Roles = roller.Select(x => x.Ad).ToList()
            };

            return Ok(kullaniciDto);
        }
    }
}

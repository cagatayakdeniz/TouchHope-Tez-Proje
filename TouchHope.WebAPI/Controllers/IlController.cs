using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouchHope.Business.Abstract;
using TouchHope.Entities.Dtos;

namespace TouchHope.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IlController : ControllerBase
    {
        private IIlService _ilService;
        private IMapper _mapper;

        public IlController(IIlService ilService, IMapper mapper)
        {
            _mapper = mapper;
            _ilService = ilService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<IlListDto>>(await _ilService.GetAllAsync()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<IlListDto>(await _ilService.FindByIdAsync(id)));
        }
    }
}

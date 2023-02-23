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
    public class CinsiyetController : ControllerBase
    {
        private ICinsiyetService _cinsiyetService;
        private IMapper _mapper;

        public CinsiyetController(ICinsiyetService cinsiyetService, IMapper mapper)
        {
            _cinsiyetService = cinsiyetService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_mapper.Map<List<CinsiyetListDto>>(await _cinsiyetService.GetAllAsync()));
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<CinsiyetListDto>(await _cinsiyetService.FindByIdAsync(id)));
        }
    }
}

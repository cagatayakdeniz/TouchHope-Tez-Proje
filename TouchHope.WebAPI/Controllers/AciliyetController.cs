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
    public class AciliyetController : ControllerBase
    {
        private IMapper _mapper;
        private IAciliyetService _aciliyetService;
        public AciliyetController(IMapper mapper, IAciliyetService aciliyetService)
        {
            _aciliyetService = aciliyetService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetirHepsi()
        {
            return Ok(_mapper.Map<List<AciliyetListDto>>(await _aciliyetService.GetAllAsync()));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsBirStajAPI.DTOs;
using IsBirStajAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IsBirStajAPI.Controllers
{
    [ApiController]
    [Route("api/Donanim")]
    public class DonanımController:ControllerBase
    {
        private readonly IDonanımRepositry _donanımRepository;
        public DonanımController(IDonanımRepositry donanımRepositry)
        {
            _donanımRepository = donanımRepositry;
        }

        [HttpGet("en/{enNo}")]
        public async Task<IActionResult> GetByEN(string enNo)
        {
            var response = await _donanımRepository.GetDonanımByENAsync(enNo);
            if(response == null)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPatch("update/{enNo}")]
        public async Task<IActionResult> Update(string enNo, [FromBody] DonanımUpdateDto dto)
        {
            var response = await _donanımRepository.UpdateKullaniciVeyaDurumAsync(enNo, dto);
            if(response == null)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
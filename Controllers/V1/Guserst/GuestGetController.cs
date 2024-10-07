using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Guests;
using PruebaNET_JuanPabloGomezBustamante.Models;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Gusersts
{
    [Route("api/v1/guests")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("guest")]
    public class GuestGetController(IGuest guest) : GuestController(guest)
    {
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Guest>>> GetAll()
        {
            var guests = await _guest.GetAll();
            return Ok(guests);
        }

        [HttpGet("{id}")]
        [Authorize]

        public async Task<ActionResult<Guest>> GetById(int id)
        {
            var guests = await _guest.GetById(id);

            if (guests == null)
            {
                return NotFound();
            }
            return guests;
        }

        [HttpGet("serach/{keyword}")]
        public async Task<ActionResult<IEnumerable<Guest>>> SearchByKeyword(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return BadRequest("La palabra clave no puede estar vasia");
            }

            var guests = await _guest.GetByKeyword(keyword);

            if (!guests.Any())
            {
                return NotFound("no se encontraron usuarios con concidencias");
            }

            return Ok(guests);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Models;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.RoomsTypes
{
    [Route("api/v1/roomstypes")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("roomstype")]
    public class RoomsTypeGetController(IRoomsType roomsType) : RoomsTypeController(roomsType)
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomType>>> GetAll()
        {
            var roomsType = await _roomsType.GetAll();
            return Ok(roomsType);
        }

        [HttpGet("serach/{keyword}")]
        public async Task<ActionResult<IEnumerable<RoomType>>> SearchByKeyword(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return BadRequest("La palabra clave no puede estar vasia");
            }

            var roomTypes = await _roomsType.GetByKeyword(keyword);

            if (!roomTypes.Any())
            {
                return NotFound("no se encontraron usuarios con concidencias");
            }

            return Ok(roomTypes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RoomType>> GetById(int id)
        {
            var roomsType = await _roomsType.GetById(id);

            if (roomsType == null)
            {
                return NotFound();
            }
            return roomsType;
        }
    }
}
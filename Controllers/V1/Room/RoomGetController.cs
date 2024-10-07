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

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Rooms
{
    [Route("api/v1/room")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("room")]
    public class RoomGetController(IRoom room) : RoomController(room)
    {
        [HttpGet("available")]
        public ActionResult<IEnumerable<Room>> GetAvailable()
        {
            var availableRooms = _rooms.GetAvailable();
            return Ok(availableRooms);
        }

        [HttpGet("summary")]
        public ActionResult GetRoomSummary()
        {
            var summary = _rooms.Getavailable();
            return Ok(summary);
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Room>>> GetAll()
        {
            var rooms = await _rooms.GetAll();
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        [Authorize]
        public ActionResult<Room> GetRoomDetails(int id)
        {
            var room = _rooms.GetRoomDetails(id);
            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        [HttpGet("occupied")]
        [Authorize]
        public ActionResult<IEnumerable<Room>> GetOccupiedRooms()
        {
            var occupiedRooms = _rooms.GetOccupied();
            return Ok(occupiedRooms);
        }
    }
}
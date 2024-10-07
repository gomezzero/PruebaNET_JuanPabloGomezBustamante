using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Models;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Bookings
{
    [Route("api/v1/bookings")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("booking")]
    public class BookingGetController(IBooking booking) : BookingController(booking)
    {
        [HttpGet("search/{identification_number}")]
        public async Task<ActionResult<IEnumerable<Booking>>> GetIdentification(string identification_number)
        {
            var bookings = await _booking.GetIdentification(identification_number);
            
            if (bookings == null || !bookings.Any())
            {
                return NotFound("No bookings found for this guest.");
            }

            return Ok(bookings);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Booking>> GetById(int id)
        {
            var booking = await _booking.GetById(id);

            if (booking == null)
            {
                return NotFound($"Booking with id {id} not found.");
            }

            return Ok(booking);
        }

    }
}
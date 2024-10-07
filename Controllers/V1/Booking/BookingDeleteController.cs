using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Bookings
{
    [Route("api/v1/bookings")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("booking")]
    public class BookingDeleteController(IBooking booking) : BookingController(booking)
    {
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult> DeleteBooking(int id)
        {
            var bookingExists = await _booking.CheckExistence(id);
            if (!bookingExists)
            {
                return NotFound($"Booking with id {id} not found.");
            }

            await _booking.Delete(id);

            return NoContent();
        }
    }
    }

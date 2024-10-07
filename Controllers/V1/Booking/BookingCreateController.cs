using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.DTOs;
using PruebaNET_JuanPabloGomezBustamante.Models;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Bookings
{
    [Route("api/v1/bookings")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("booking")]
    public class BookingCreateController(IBooking booking) : BookingController(booking)
    {
        [HttpPost]
        [Authorize] 
        public async Task<ActionResult<Booking>> CreateBooking(BookingDTO booking1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var booking = new Booking(booking1.StarDate, booking1.EndDate, booking1.TotalCost, booking1.RoomId, booking1.GuestId, booking1.EmployeeId);

            await _booking.Add(booking);

            return CreatedAtAction(nameof(BookingGetController.GetById), new { id = booking.Id }, booking);
        }
    }
}
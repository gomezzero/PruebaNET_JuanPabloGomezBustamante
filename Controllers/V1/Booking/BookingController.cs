using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Bookings
{
    [Route("api/V1/[controller]")]
    public class BookingController(IBooking booking) : ControllerBase
    {
        protected readonly IBooking _booking = booking;
    }
}

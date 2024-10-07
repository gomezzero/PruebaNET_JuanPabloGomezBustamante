using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Guests
{
    [Route("api/v1/[controller]")]
    public class GuestController(IGuest guest) : ControllerBase
    {
        protected readonly IGuest _guest = guest;
    }
}
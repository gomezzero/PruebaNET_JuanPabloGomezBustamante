using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Rooms
{
    [Route("api/V1[controller]")]
    public class RoomController(IRoom rooms) : ControllerBase
    {
        protected readonly IRoom _rooms = rooms;
    }
}
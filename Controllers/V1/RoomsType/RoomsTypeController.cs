using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.RoomsTypes
{
    [Route("api/V1[controller]")]
    public class RoomsTypeController(IRoomsType roomsType) : ControllerBase
    {
        protected readonly IRoomsType _roomsType = roomsType;
    }
}
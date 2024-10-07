using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.FreeAccess
{
    [Route("api/V1[controller]")]
    public class EmployeeController(IEmployee employee) : ControllerBase
    {
        protected readonly IEmployee _employee = employee;
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.FreeAccess.Employees
{
    [Route("api/v1/employees")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("employee")]
    public class EmployeeDeleteController(IEmployee employee) : EmployeeController(employee)
    {
        [HttpDelete("{id}")]
        [Authorize] // etiqueta para permitir bloquear el uso de enpins con JWT

        public async Task<IActionResult> Delete(int id)
        {
            var user = await _employee.CheckExistence(id);

            if (user == false)
            {
                return NotFound();
            }

            await _employee.Delete(id);

            return NotFound();
        }
    }
}
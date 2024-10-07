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
using PruebaNET_JuanPabloGomezBustamante.Utils;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.FreeAccess.Employees
{
    [Route("api/v1/employees")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("employee")]
    public class EmployeeCreateController(IEmployee employee) : EmployeeController(employee)
    {
        [HttpPost]
        [Authorize] // etiqueta para permitir bloquear el uso de enpins con JWT
        public async Task<ActionResult<Employee>> Create(EmployeeDTO inputUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Hashear la contraseña antes de guardar
            var hashedPassword = PasswordHasher.HashPassword(inputUser.Password);

            var newUser = new Employee(inputUser.FirstName, inputUser.LastName, inputUser.Email, inputUser.IdentificationNumeber, hashedPassword);

            await _employee.Add(newUser);

            return Ok(newUser);
        }
    }
}
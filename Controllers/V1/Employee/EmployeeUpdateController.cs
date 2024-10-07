using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Controllers.V1.FreeAccess;
using PruebaNET_JuanPabloGomezBustamante.DTOs;
using PruebaNET_JuanPabloGomezBustamante.Repositories;
using PruebaNET_JuanPabloGomezBustamante.Utils;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Employees
{
    [Route("api/v1/employees")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("employee")]
    public class EmployeeUpdateController(IEmployee employee) : EmployeeController(employee)
    {
        [HttpPut("{id}")]
        [Authorize] // etiqueta para permitir bloquear el uso de endpoints con JWT
        public async Task<IActionResult> Update(int id, EmployeeDTO updateUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var checkUser = await _employee.CheckExistence(id);

            if (!checkUser)
            {
                return NotFound();
            }

            var user = await _employee.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            // Actualizamos los campos del usuario
            user.FirstName = updateUser.FirstName;
            user.LastName = updateUser.LastName;
            user.Email = updateUser.Email;
            user.IdentificationNumeber = updateUser.IdentificationNumeber;


            // Si se proporciona una nueva contraseña, la hasheamos
            if (!string.IsNullOrWhiteSpace(updateUser.Password))
            {
                user.Password = PasswordHasher.HashPassword(updateUser.Password);
            }

            await _employee.Update(user);
            return NoContent();
        }
    }
}
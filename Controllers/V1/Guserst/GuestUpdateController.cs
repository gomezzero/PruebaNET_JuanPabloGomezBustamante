using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Guests;
using PruebaNET_JuanPabloGomezBustamante.DTOs;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Gusersts
{
    [Route("api/v1/guests")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("guest")]
    public class GuestUpdateController(IGuest guest) : GuestController(guest)
    {
        [HttpPut("{id}")]
        [Authorize] // etiqueta para permitir bloquear el uso de endpoints con JWT
        public async Task<IActionResult> Update(int id, GuestDTO updateUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _guest.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            // Actualizamos los campos del usuario
            user.FirstName = updateUser.FirstName;
            user.LastName = updateUser.LastName;
            user.Email = updateUser.Email;
            user.IdentificationNumeber = updateUser.IdentificationNumeber;
            user.PhoneNumber = updateUser.PhoneNumber;
            user.Birthdate = updateUser.Birthdate;

            await _guest.Update(user);
            return NoContent();
        }
    }
}
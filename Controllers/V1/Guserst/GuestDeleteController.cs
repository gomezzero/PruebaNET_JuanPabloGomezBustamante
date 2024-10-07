using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Guests;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Gusersts
{
    [Route("api/v1/guests")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("guest")]
    public class GuestDeleteController(IGuest guest) : GuestController(guest)
    {
        [HttpDelete("{id}")]
        [Authorize] // etiqueta para permitir bloquear el uso de enpins con JWT

        public async Task<IActionResult> Delete(int id)
        {
            await _guest.Delete(id);

            return NotFound();
        }
    }
}
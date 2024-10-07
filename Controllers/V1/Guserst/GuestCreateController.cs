
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JuanPabloGomezBustamante.DTOs;
using PruebaNET_JuanPabloGomezBustamante.Models;
using PruebaNET_JuanPabloGomezBustamante.Repositories;
using PruebaNET_JuanPabloGomezBustamante.Services;
using PruebaNET_JuanPabloGomezBustamante.Utils;


namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.Guests
{
    [Route("api/v1/guests")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("guest")]
    public class GuestCreateController(IGuest guest) : GuestController(guest)
    {
        [HttpPost]
        public async Task<ActionResult<Guest>> Create(GuestDTO inputUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newUser = new Guest(inputUser.FirstName, inputUser.LastName, inputUser.Email, inputUser.IdentificationNumeber, inputUser.PhoneNumber, inputUser.Birthdate);

            await _guest.Add(newUser);

            return Ok(newUser);
        }
    }
}
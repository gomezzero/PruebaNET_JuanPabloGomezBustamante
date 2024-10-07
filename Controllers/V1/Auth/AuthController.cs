using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JuanPabloGomezBustamante.Config;
using PruebaNET_JuanPabloGomezBustamante.DTOs.Requets;
using PruebaNET_JuanPabloGomezBustamante.Repositories;
using PruebaNET_JuanPabloGomezBustamante.Utils;

namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.FreeAccess.Auth
{
    [Route("api/v1/auth")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class AuthController : ControllerBase
    {
        protected readonly IEmployee servicios;

        public AuthController(IEmployee employee)
        {
            servicios = employee;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginDTO data)
        {
            var employee = await servicios.GetByEmail(data.Email);

            if (employee == null)
            {
                return BadRequest("El empleado no existe");
            }

            // Verificar la contraseña hasheada
            bool isPasswordValid = PasswordHasher.VerifyPassword(data.Password, employee.Password);

            if (!isPasswordValid)
            {
                return BadRequest("Contraseña incorrecta");
            }


            var token = JWT.GenerateJwtToken(employee);

            return Ok($"Token valido por 60 min: {token}");
        }
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_JuanPabloGomezBustamante.Models;
using PruebaNET_JuanPabloGomezBustamante.Repositories;


namespace PruebaNET_JuanPabloGomezBustamante.Controllers.V1.FreeAccess.Employees
{
    [Route("api/v1/employees")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("employee")]
    public class EmployeeGetController(IEmployee employee) : EmployeeController(employee)
    {
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
        {
            var employee = await _employee.GetAll();
            return Ok(employee);
        }

        [HttpGet("{id}")]
        [Authorize]

        public async Task<ActionResult<Employee>> GetById(int id)
        {
            var employee = await _employee.GetById(id);

            if (employee == null)
            {
                return NotFound();
            }
            return employee;
        }
    }
}
using Microsoft.EntityFrameworkCore;
using PruebaNET_JuanPabloGomezBustamante.Data;
using PruebaNET_JuanPabloGomezBustamante.Models;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Services
{
    public class EmployeeServices : IEmployee
    {
        private readonly MyDbContext _context;

        public EmployeeServices(MyDbContext context)
        {
            _context = context;
        }

        public async Task Add(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(Employee), "El Empleado no puede ser nulo");
            }

            try
            {
                await _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error al agregar el Empleado a la base de datos", dbExi);
            }
            catch (Exception exi)
            {
                throw new Exception("ocurrio un error a la hora de agregar el Empleado", exi);
            }
        }

        public async Task<bool> CheckExistence(int id)
        {
            try
            {
                return await _context.Employees.AnyAsync(u => u.Id == id);
            }
            catch (Exception exi)
            {
                throw new Exception("ocurrio un error a la hora de busacar el Empleadp", exi);
            }
        }

        public async Task Delete(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();

        }
        public async Task Update(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "el Empleadp no puede ser nulo");
            }

            try
            {
                _context.Entry(employee).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error al actualizar el Empleadp en la base de datos", dbExi);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar el Empleadp.", ex);
            }
        }

        public async Task<Employee?> GetByEmail(string email)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<Employee?> GetById(int id)
        {
            return await _context.Employees.FindAsync(id);

        }

    }
}
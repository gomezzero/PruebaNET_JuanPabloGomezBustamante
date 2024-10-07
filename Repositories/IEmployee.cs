
using PruebaNET_JuanPabloGomezBustamante.Models;

namespace PruebaNET_JuanPabloGomezBustamante.Repositories
{
    public interface IEmployee
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee?> GetById(int id);
        Task<Employee?> GetByEmail(string email);
        Task Add(Employee employee);
        Task Update(Employee employee);
        Task Delete(int id);
        Task<bool> CheckExistence(int id);
    }
}
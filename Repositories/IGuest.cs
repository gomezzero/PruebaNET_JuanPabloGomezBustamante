using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_JuanPabloGomezBustamante.Models;

namespace PruebaNET_JuanPabloGomezBustamante.Repositories
{
    public interface IGuest
    {
        Task Add(Guest guest);
        Task Update(Guest guest);
        Task Delete(int id);
        Task<Guest?> GetById(int id);
        Task<IEnumerable<Guest>> GetByKeyword(string keyword);
        Task<IEnumerable<Guest>> GetAll();

    }
}
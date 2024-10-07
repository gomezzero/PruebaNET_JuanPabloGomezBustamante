using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_JuanPabloGomezBustamante.Models;

namespace PruebaNET_JuanPabloGomezBustamante.Repositories
{
    public interface IBooking
    {
        Task<IEnumerable<Booking>> GetIdentification(string identificationNumber);

        Task<Booking?> GetById(int id);

        Task Add(Booking booking);

        Task Delete(int id);

        Task<bool> CheckExistence(int id);
    }
}
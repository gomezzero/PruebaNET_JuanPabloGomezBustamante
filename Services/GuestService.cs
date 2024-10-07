using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaNET_JuanPabloGomezBustamante.Data;
using PruebaNET_JuanPabloGomezBustamante.Models;
using PruebaNET_JuanPabloGomezBustamante.Repositories;

namespace PruebaNET_JuanPabloGomezBustamante.Services
{
    public class GuestService : IGuest
    {
        private readonly MyDbContext _context;

        public GuestService(MyDbContext context)
        {
            _context = context;
        }

        public async Task Add(Guest guest)
        {
            if (guest == null)
            {
                throw new ArgumentNullException(nameof(guest), "El Cliente no puede ser nulo");
            }

            try
            {
                await _context.Guests.AddAsync(guest);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error al agregar el Cliente a la base de datos", dbExi);
            }
            catch (Exception exi)
            {
                throw new Exception("ocurrio un error a la hora de agregar el Cliente", exi);
            }
        }

        public async Task Delete(int id)
        {
            var guest = await _context.Guests.FindAsync(id);

            if (guest != null)
            {
                _context.Guests.Remove(guest);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Guest>> GetAll()
        {
            return await _context.Guests.ToListAsync();
        }

        public async Task<Guest?> GetById(int id)
        {
            return await _context.Guests.FindAsync(id);
        }

        public async Task<IEnumerable<Guest>> GetByKeyword(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return await GetAll();
            }

            return await _context.Guests.Where(u => u.FirstName.Contains(keyword) || u.Email.Contains(keyword) || u.IdentificationNumeber.Contains(keyword) || u.LastName.Contains(keyword)).ToListAsync();

        }

        public async Task Update(Guest guest)
        {
            if (guest == null)
            {
                throw new ArgumentNullException(nameof(guest), "el cliente no puede ser nulo");
            }

            try
            {
                _context.Entry(guest).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error al actualizar el cliente en la base de datos", dbExi);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar el cliente.", ex);
            }
        }
    }
}
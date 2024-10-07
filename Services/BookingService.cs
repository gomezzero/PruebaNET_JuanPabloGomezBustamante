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
    public class BookingService : IBooking
    {
        private readonly MyDbContext _context;

        public BookingService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Booking>> GetIdentification(string identificationNumber)
        {
            return await _context.Bookings.Include(b => b.Guest).Where(b => b.Guest.IdentificationNumeber == identificationNumber).ToListAsync();
        }

        public async Task<Booking?> GetById(int id)
        {
            return await _context.Bookings.Include(b => b.Room).Include(b => b.Guest).Include(b => b.Employee).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task Add(Booking booking)
        {
            if (booking == null)
            {
                throw new ArgumentNullException(nameof(Booking), "la reserva no puede ser nulo");
            }

            try
            {
                await _context.Bookings.AddAsync(booking);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error al agregar la reserva a la base de datos", dbExi);
            }
            catch (Exception exi)
            {
                throw new Exception("ocurrio un error a la hora de agregar la reserva", exi);
            }
        }

        public async Task Delete(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> CheckExistence(int id)
        {
            return await _context.Bookings.AnyAsync(b => b.Id == id);
        }
    }
}

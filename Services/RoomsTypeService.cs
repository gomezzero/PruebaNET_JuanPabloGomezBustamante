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
    public class RoomsTypeService : IRoomsType
    {
        private readonly MyDbContext _context;

        public RoomsTypeService(MyDbContext context)
        {
            _context = context;
        }

        public async Task Add(RoomType roomType)
        {
            if (roomType == null)
            {
                throw new ArgumentNullException(nameof(RoomType), "el tipo de habitacion no puede ser nulo");
            }

            try
            {
                await _context.RoomTypes.AddAsync(roomType);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbExi)
            {
                throw new Exception("Error al agregar el tipo de habitacion a la base de datos", dbExi);
            }
            catch (Exception exi)
            {
                throw new Exception("ocurrio un error a la hora de agregar el tipo de habitacion", exi);
            }
        }

        public async Task Delete(int id)
        {
            var roomType = await _context.RoomTypes.FindAsync(id);

            if (roomType != null)
            {
                _context.RoomTypes.Remove(roomType);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<RoomType>> GetAll()
        {
            return await _context.RoomTypes.ToListAsync();

        }

        public async Task<IEnumerable<RoomType>> GetByKeyword(string keyword)
        {
            if(string.IsNullOrWhiteSpace(keyword))
            {
                return await GetAll();
            }

            return await _context.RoomTypes.Where(u => u.Name.Contains(keyword) || u.Description.Contains(keyword)).ToListAsync();
        }

        public async Task Update(RoomType roomType)
        {
            if (roomType == null)
            {
                throw new ArgumentNullException(nameof(roomType), "el Empleadp no puede ser nulo");
            }

            try
            {
                _context.Entry(roomType).State = EntityState.Modified;
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
    }
}
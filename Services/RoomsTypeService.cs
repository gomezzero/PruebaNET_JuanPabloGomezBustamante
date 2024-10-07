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
        public async Task<IEnumerable<RoomType>> GetAll()
        {
            return await _context.RoomTypes.ToListAsync();
        }

        public async Task<IEnumerable<RoomType>> GetByKeyword(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return await GetAll();
            }

            return await _context.RoomTypes.Where(u => u.Name.Contains(keyword) || u.Description.Contains(keyword)).ToListAsync();
        }

        public async Task<RoomType?> GetById(int id)
        {
            return await _context.RoomTypes.FindAsync(id);
        }

    }
}
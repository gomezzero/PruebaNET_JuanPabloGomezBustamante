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
    public class RoomService : IRoom
    {
        private readonly MyDbContext _context;

        public RoomService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Room>> GetAll()
        {
            return await _context.Rooms.ToListAsync();
        }

        public IEnumerable<Room> GetAvailable()
        {
           return _context.Rooms.Where(r => r.Availability).ToList();
        }

        public (int OccupiedRooms, int AvailableRooms) Getavailable()
        {
            int availableRooms = _context.Rooms.Count(r => r.Availability);
            int occupiedRooms = _context.Rooms.Count(r => !r.Availability);

            return (occupiedRooms, availableRooms);
        }

        public IEnumerable<Room> GetOccupied()
        {
             return _context.Rooms.Where(r => !r.Availability).ToList();
        }

        public Room GetRoomDetails(int id)
        {
             return _context.Rooms.FirstOrDefault(r => r.Id == id);
        }
    }
}
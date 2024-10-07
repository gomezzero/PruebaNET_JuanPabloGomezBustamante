using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_JuanPabloGomezBustamante.Models;

namespace PruebaNET_JuanPabloGomezBustamante.Repositories
{
    public interface IRoom
    {
        IEnumerable<Room> GetAvailable(); // libre
        (int OccupiedRooms, int AvailableRooms) Getavailable();
        Task<IEnumerable<Room>> GetAll();
        Room GetRoomDetails(int id);
       IEnumerable<Room> GetOccupied(); // libre
    }
}
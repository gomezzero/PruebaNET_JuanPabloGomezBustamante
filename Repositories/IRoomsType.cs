
using PruebaNET_JuanPabloGomezBustamante.Models;

namespace PruebaNET_JuanPabloGomezBustamante.Repositories
{
    public interface IRoomsType
    {
        Task<IEnumerable<RoomType>> GetAll();
        Task<IEnumerable<RoomType>> GetByKeyword(string keyword);
        Task<RoomType?> GetById(int id);

    }
}
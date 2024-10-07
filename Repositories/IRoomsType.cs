
using PruebaNET_JuanPabloGomezBustamante.Models;

namespace PruebaNET_JuanPabloGomezBustamante.Repositories
{
    public interface IRoomsType
    {
        Task<IEnumerable<RoomType>> GetAll();
        Task Add(RoomType roomType);
        Task Update(RoomType roomType);
        Task Delete(int id);
        Task<IEnumerable<RoomType>> GetByKeyword(string keyword);

    }
}

using System.ComponentModel.DataAnnotations;

namespace PruebaNET_JuanPabloGomezBustamante.DTOs
{
    public class RoomTypeDTO
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
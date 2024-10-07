
using System.ComponentModel.DataAnnotations;

namespace PruebaNET_JuanPabloGomezBustamante.DTOs
{
    public class RoomDTO
    {
        [Required]
        public string RoomNumber { get; set; }

        [Required]
        public double PricePerNight { get; set; }

        [Required]
        public bool Availability { get; set; }

        [Required]
        public byte MaxOccupancyPerson { get; set; }

        [Required]
        public int RoomTypeId { get; set; }

    }
}
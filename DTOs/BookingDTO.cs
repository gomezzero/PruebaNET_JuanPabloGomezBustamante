using System.ComponentModel.DataAnnotations;

namespace PruebaNET_JuanPabloGomezBustamante.DTOs
{
    public class BookingDTO
    {
        [Required]
        public DateTime StarDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public double TotalCost { get; set; }

        [Required]
        public int RoomId { get; set;}

        [Required]
        public int GuestId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace PruebaNET_JuanPabloGomezBustamante.DTOs
{
    public class GuestDTO
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string IdentificationNumeber { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }
        
    }
}
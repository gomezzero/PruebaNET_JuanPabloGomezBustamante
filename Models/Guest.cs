using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_JuanPabloGomezBustamante.Models
{
    [Table("gests")]
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("identification_numeber")]
        public string IdentificationNumeber { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Column("birthdate")]
        public DateTime Birthdate { get; set; }

        public Guest(string firstName, string lastName, string email, string identificationNumeber, string phoneNumber, DateTime birthdate)
        {
            FirstName = firstName.ToLower().Trim();
            LastName = lastName.ToLower().Trim();
            Email = email.ToLower().Trim();
            IdentificationNumeber = identificationNumeber.Trim();
            PhoneNumber = phoneNumber.Trim();
            Birthdate = birthdate;
        }
    }
}
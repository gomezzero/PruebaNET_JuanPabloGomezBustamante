using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNET_JuanPabloGomezBustamante.Models
{
    [Table("employees")]
    public class Employee
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

        [Column("password")]
        public string Password { get; set; }

        public Employee(string firstName, string lastName, string email, string identificationNumeber, string password)
        {
            FirstName = firstName.ToLower().Trim();
            LastName = lastName.ToLower().Trim();
            Email = email.ToLower().Trim();
            IdentificationNumeber = identificationNumeber.Trim();
            Password = password;
        }
    }
}
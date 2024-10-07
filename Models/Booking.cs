using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PruebaNET_JuanPabloGomezBustamante.Models
{
    [Table("bookings")]
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("star_date")]
        public DateTime StarDate { get; set; }

        [Column("end_date")]
        public DateTime EndDate { get; set; }

        [Column("total_cost")]
        public double TotalCost { get; set; }

        // foreign key
        [Column("room_id")]
        public int RoomId { get; set;}

        [Column("guest_id")]
        public int GuestId { get; set; }

        [Column("employee_id")]
        public int EmployeeId { get; set; }

        // connection with foreign key
        [ForeignKey("room_id")]
        public required Room Room { get; set; }

        [ForeignKey("guest_id")]
        public required Guest Guest { get; set; }

        [ForeignKey("employee_id")]
        public required Employee Employee { get; set; }

        public Booking(DateTime starDate, DateTime endDate, double totalCost, int roomId, int guestId, int employeeId)
        {
            StarDate = starDate;
            EndDate = endDate;
            TotalCost = totalCost;
            RoomId = roomId;
            GuestId = guestId;
            EmployeeId = employeeId;
        }
    }
}
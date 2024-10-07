using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNET_JuanPabloGomezBustamante.Models
{
    [Table("rooms")]
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("room_number")]
        public string RoomNumber { get; set; }

        [Column("price_per_night")]
        public double PricePerNight { get; set; }

        [Column("availability")]
        public bool Availability { get; set; }

        [Column("max_occupancy_persons")]
        public byte MaxOccupancyPerson { get; set; }

        // foreign key
        [Column("room_type_id")]
        public int RoomTypeId { get; set; }

        // connection with foreign key
        [ForeignKey("room_type_id")]
        public RoomType? RoomType { get; set; }

        public Room(string roomNumber, double pricePerNight, bool availability, byte maxOccupancyPerson, int roomTypeId)
        {
            RoomNumber = roomNumber;
            PricePerNight = pricePerNight;
            Availability = availability;
            MaxOccupancyPerson = maxOccupancyPerson;
            RoomTypeId = roomTypeId;
        }
    }
}
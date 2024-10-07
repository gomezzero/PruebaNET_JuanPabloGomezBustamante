using Microsoft.EntityFrameworkCore;
using PruebaNET_JuanPabloGomezBustamante.Models;

namespace PruebaNET_JuanPabloGomezBustamante.Seeders
{
    public static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Crear los RoomTypes
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType("Habitación Simple", "Una acogedora habitación básica con una cama individual, ideal para viajeros solos.") { Id = 1 },
                new RoomType("Habitación Doble", "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos.") { Id = 2 },
                new RoomType("Suite", "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad.") { Id = 3 },
                new RoomType("Habitación Familiar", "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.") { Id = 4 }
            );

            // Crear las habitaciones (50 habitaciones, 5 pisos con 10 habitaciones cada uno)
            int roomNumberCounter = 1;
            for (int floor = 1; floor <= 5; floor++)
            {
                for (int room = 1; room <= 10; room++)
                {
                    int roomTypeId;
                    double price;
                    byte maxOccupancy;

                    // Asignar RoomType y precios dependiendo del tipo de habitación
                    if (room <= 3)
                    {
                        roomTypeId = 1; // Habitación Simple
                        price = 50;
                        maxOccupancy = 1;
                    }
                    else if (room <= 6)
                    {
                        roomTypeId = 2; // Habitación Doble
                        price = 80;
                        maxOccupancy = 2;
                    }
                    else if (room <= 8)
                    {
                        roomTypeId = 3; // Suite
                        price = 150;
                        maxOccupancy = 2;
                    }
                    else
                    {
                        roomTypeId = 4; // Habitación Familiar
                        price = 200;
                        maxOccupancy = 4;
                    }

                    modelBuilder.Entity<Room>().HasData(
                        new Room($"P{floor}H{roomNumberCounter}", price, true, maxOccupancy, roomTypeId)
                        {
                            Id = roomNumberCounter
                        }
                    );

                    roomNumberCounter++;
                }
            }
        }
    }
}
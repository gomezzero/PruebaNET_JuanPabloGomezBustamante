﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaNET_JuanPabloGomezBustamante.Data;

#nullable disable

namespace PruebaNET_JuanPabloGomezBustamante.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20241007155942_SeedRoomAndRoomTypes")]
    partial class SeedRoomAndRoomTypes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("PruebaNET_JuanPabloGomezBustamante.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("end_date");

                    b.Property<int>("GuestId")
                        .HasColumnType("int")
                        .HasColumnName("guest_id");

                    b.Property<int>("RoomId")
                        .HasColumnType("int")
                        .HasColumnName("room_id");

                    b.Property<DateTime>("StarDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("star_date");

                    b.Property<double>("TotalCost")
                        .HasColumnType("double")
                        .HasColumnName("total_cost");

                    b.Property<int>("employee_id")
                        .HasColumnType("int");

                    b.Property<int>("guest_id")
                        .HasColumnType("int");

                    b.Property<int>("room_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("employee_id");

                    b.HasIndex("guest_id");

                    b.HasIndex("room_id");

                    b.ToTable("bookings", t =>
                        {
                            t.Property("employee_id")
                                .HasColumnName("employee_id1");

                            t.Property("guest_id")
                                .HasColumnName("guest_id1");

                            t.Property("room_id")
                                .HasColumnName("room_id1");
                        });
                });

            modelBuilder.Entity("PruebaNET_JuanPabloGomezBustamante.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("IdentificationNumeber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("identification_numeber");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("PruebaNET_JuanPabloGomezBustamante.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("birthdate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("IdentificationNumeber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("identification_numeber");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("gests");
                });

            modelBuilder.Entity("PruebaNET_JuanPabloGomezBustamante.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("availability");

                    b.Property<byte>("MaxOccupancyPerson")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("max_occupancy_persons");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("double")
                        .HasColumnName("price_per_night");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("room_number");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int")
                        .HasColumnName("room_type_id");

                    b.Property<int?>("room_type_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("room_type_id");

                    b.ToTable("rooms", t =>
                        {
                            t.Property("room_type_id")
                                .HasColumnName("room_type_id1");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P1H1",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P1H2",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P1H3",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P1H4",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P1H5",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P1H6",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 7,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "P1H7",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 8,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "P1H8",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 9,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "P1H9",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 10,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "P1H10",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 11,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P2H11",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 12,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P2H12",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 13,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P2H13",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 14,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P2H14",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 15,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P2H15",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 16,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P2H16",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 17,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "P2H17",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 18,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "P2H18",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 19,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "P2H19",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 20,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "P2H20",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 21,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P3H21",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 22,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P3H22",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 23,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P3H23",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 24,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P3H24",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 25,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P3H25",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 26,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P3H26",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 27,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "P3H27",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 28,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "P3H28",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 29,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "P3H29",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 30,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "P3H30",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 31,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P4H31",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 32,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P4H32",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 33,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P4H33",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 34,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P4H34",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 35,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P4H35",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 36,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P4H36",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 37,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "P4H37",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 38,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "P4H38",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 39,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "P4H39",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 40,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "P4H40",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 41,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P5H41",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 42,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P5H42",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 43,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 50.0,
                            RoomNumber = "P5H43",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 44,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P5H44",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 45,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P5H45",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 46,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 80.0,
                            RoomNumber = "P5H46",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 47,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "P5H47",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 48,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 150.0,
                            RoomNumber = "P5H48",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 49,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "P5H49",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 50,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 200.0,
                            RoomNumber = "P5H50",
                            RoomTypeId = 4
                        });
                });

            modelBuilder.Entity("PruebaNET_JuanPabloGomezBustamante.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("room_types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "una acogedora habitación básica con una cama individual, ideal para viajeros solos.",
                            Name = "habitación simple"
                        },
                        new
                        {
                            Id = 2,
                            Description = "ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos.",
                            Name = "habitación doble"
                        },
                        new
                        {
                            Id = 3,
                            Description = "espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad.",
                            Name = "suite"
                        },
                        new
                        {
                            Id = 4,
                            Description = "diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.",
                            Name = "habitación familiar"
                        });
                });

            modelBuilder.Entity("PruebaNET_JuanPabloGomezBustamante.Models.Booking", b =>
                {
                    b.HasOne("PruebaNET_JuanPabloGomezBustamante.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaNET_JuanPabloGomezBustamante.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("guest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaNET_JuanPabloGomezBustamante.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("room_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("PruebaNET_JuanPabloGomezBustamante.Models.Room", b =>
                {
                    b.HasOne("PruebaNET_JuanPabloGomezBustamante.Models.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("room_type_id");

                    b.Navigation("RoomType");
                });
#pragma warning restore 612, 618
        }
    }
}

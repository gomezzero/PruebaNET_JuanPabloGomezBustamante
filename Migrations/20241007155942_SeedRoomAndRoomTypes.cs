using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaNET_JuanPabloGomezBustamante.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoomAndRoomTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rooms_room_types_room_type_id1",
                table: "rooms");

            migrationBuilder.AlterColumn<int>(
                name: "room_type_id1",
                table: "rooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "room_types",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "una acogedora habitación básica con una cama individual, ideal para viajeros solos.", "habitación simple" },
                    { 2, "ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos.", "habitación doble" },
                    { 3, "espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad.", "suite" },
                    { 4, "diseñada para familias, con espacio adicional y varias camas para una estancia cómoda.", "habitación familiar" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "availability", "max_occupancy_persons", "price_per_night", "room_number", "room_type_id", "room_type_id1" },
                values: new object[,]
                {
                    { 1, true, (byte)1, 50.0, "P1H1", 1, null },
                    { 2, true, (byte)1, 50.0, "P1H2", 1, null },
                    { 3, true, (byte)1, 50.0, "P1H3", 1, null },
                    { 4, true, (byte)2, 80.0, "P1H4", 2, null },
                    { 5, true, (byte)2, 80.0, "P1H5", 2, null },
                    { 6, true, (byte)2, 80.0, "P1H6", 2, null },
                    { 7, true, (byte)2, 150.0, "P1H7", 3, null },
                    { 8, true, (byte)2, 150.0, "P1H8", 3, null },
                    { 9, true, (byte)4, 200.0, "P1H9", 4, null },
                    { 10, true, (byte)4, 200.0, "P1H10", 4, null },
                    { 11, true, (byte)1, 50.0, "P2H11", 1, null },
                    { 12, true, (byte)1, 50.0, "P2H12", 1, null },
                    { 13, true, (byte)1, 50.0, "P2H13", 1, null },
                    { 14, true, (byte)2, 80.0, "P2H14", 2, null },
                    { 15, true, (byte)2, 80.0, "P2H15", 2, null },
                    { 16, true, (byte)2, 80.0, "P2H16", 2, null },
                    { 17, true, (byte)2, 150.0, "P2H17", 3, null },
                    { 18, true, (byte)2, 150.0, "P2H18", 3, null },
                    { 19, true, (byte)4, 200.0, "P2H19", 4, null },
                    { 20, true, (byte)4, 200.0, "P2H20", 4, null },
                    { 21, true, (byte)1, 50.0, "P3H21", 1, null },
                    { 22, true, (byte)1, 50.0, "P3H22", 1, null },
                    { 23, true, (byte)1, 50.0, "P3H23", 1, null },
                    { 24, true, (byte)2, 80.0, "P3H24", 2, null },
                    { 25, true, (byte)2, 80.0, "P3H25", 2, null },
                    { 26, true, (byte)2, 80.0, "P3H26", 2, null },
                    { 27, true, (byte)2, 150.0, "P3H27", 3, null },
                    { 28, true, (byte)2, 150.0, "P3H28", 3, null },
                    { 29, true, (byte)4, 200.0, "P3H29", 4, null },
                    { 30, true, (byte)4, 200.0, "P3H30", 4, null },
                    { 31, true, (byte)1, 50.0, "P4H31", 1, null },
                    { 32, true, (byte)1, 50.0, "P4H32", 1, null },
                    { 33, true, (byte)1, 50.0, "P4H33", 1, null },
                    { 34, true, (byte)2, 80.0, "P4H34", 2, null },
                    { 35, true, (byte)2, 80.0, "P4H35", 2, null },
                    { 36, true, (byte)2, 80.0, "P4H36", 2, null },
                    { 37, true, (byte)2, 150.0, "P4H37", 3, null },
                    { 38, true, (byte)2, 150.0, "P4H38", 3, null },
                    { 39, true, (byte)4, 200.0, "P4H39", 4, null },
                    { 40, true, (byte)4, 200.0, "P4H40", 4, null },
                    { 41, true, (byte)1, 50.0, "P5H41", 1, null },
                    { 42, true, (byte)1, 50.0, "P5H42", 1, null },
                    { 43, true, (byte)1, 50.0, "P5H43", 1, null },
                    { 44, true, (byte)2, 80.0, "P5H44", 2, null },
                    { 45, true, (byte)2, 80.0, "P5H45", 2, null },
                    { 46, true, (byte)2, 80.0, "P5H46", 2, null },
                    { 47, true, (byte)2, 150.0, "P5H47", 3, null },
                    { 48, true, (byte)2, 150.0, "P5H48", 3, null },
                    { 49, true, (byte)4, 200.0, "P5H49", 4, null },
                    { 50, true, (byte)4, 200.0, "P5H50", 4, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_rooms_room_types_room_type_id1",
                table: "rooms",
                column: "room_type_id1",
                principalTable: "room_types",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rooms_room_types_room_type_id1",
                table: "rooms");

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.AlterColumn<int>(
                name: "room_type_id1",
                table: "rooms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_rooms_room_types_room_type_id1",
                table: "rooms",
                column: "room_type_id1",
                principalTable: "room_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

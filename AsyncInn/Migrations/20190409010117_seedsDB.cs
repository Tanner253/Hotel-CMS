using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class seedsDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Heating" },
                    { 2, "In-Unit Laundry" },
                    { 3, "Pool" },
                    { 4, "Balcony" },
                    { 5, "WiFi" }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "City", "Name", "Phone", "State", "StreetAdress" },
                values: new object[,]
                {
                    { 3, "Seattle", "TestHotel3", 1111234567, "Washington", "0002 Fake Addy" },
                    { 4, "Seattle", "TestHotel4", 221234567, "Washington", "0003 Fake Addy" },
                    { 5, "Seattle", "TestHotel5", 331234567, "Washington", "0004 Fake Addy" },
                    { 6, "Seattle", "TestHotel6", 441234567, "Washington", "0005 Fake Addy" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "Name", "RoomLayout" },
                values: new object[,]
                {
                    { 1, "Red", 0 },
                    { 2, "Blue", 0 },
                    { 3, "Green", 1 },
                    { 4, "Yellow", 1 },
                    { 5, "Orange", 2 },
                    { 6, "Purple", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}

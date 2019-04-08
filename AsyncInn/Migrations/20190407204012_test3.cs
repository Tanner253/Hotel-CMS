using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "City", "Name", "Phone", "State", "StreetAdress" },
                values: new object[] { 1, "Seattle", "TestHotel", 1234567, "Washington", "0000 Fake Addy" });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "City", "Name", "Phone", "State", "StreetAdress" },
                values: new object[] { 2, "Seattle", "TestHote2", 222222222, "Washington", "0001 Fake Addy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class deployWithupdatedseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Motel Hotel");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "KillerPillar");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "Motten");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: "Capitolhill heights");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: "shateau Percival");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 6,
                column: "Name",
                value: "Classico Francico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "TestHotel");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "TestHote2");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "TestHotel3");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 4,
                column: "Name",
                value: "TestHotel4");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 5,
                column: "Name",
                value: "TestHotel5");

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 6,
                column: "Name",
                value: "TestHotel6");
        }
    }
}

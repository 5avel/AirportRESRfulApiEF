using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportRESRfulApi.DAL.Migrations
{
    public partial class AddAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FlightNumber",
                table: "Departures",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArrivalTime", "DeparturePoint", "DepartureTime", "DestinationPoint", "FlightNumber" },
                values: new object[] { 1, new DateTime(2018, 7, 13, 13, 22, 56, 640, DateTimeKind.Local), "London", new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local), "Ukraine", "QW11" });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArrivalTime", "DeparturePoint", "DepartureTime", "DestinationPoint", "FlightNumber" },
                values: new object[] { 2, new DateTime(2018, 7, 13, 13, 22, 56, 640, DateTimeKind.Local), "Ukraine", new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local), "London", "QW12" });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "ArrivalTime", "DeparturePoint", "DepartureTime", "DestinationPoint", "FlightNumber" },
                values: new object[] { 3, new DateTime(2018, 7, 13, 13, 22, 56, 640, DateTimeKind.Local), "London", new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local), "Dnipro", "QW13" });

            migrationBuilder.InsertData(
                table: "Departures",
                columns: new[] { "Id", "DepartureTime", "FlightId", "FlightNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local), 1, "QW11" },
                    { 3, new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local), 3, "ER86" },
                    { 2, new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local), 2, "KJ76" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "FlightId", "FlightNumber", "IsSold", "PlaseNumber", "Price" },
                values: new object[,]
                {
                    { 18, 3, "ER86", false, 4, 200m },
                    { 17, 3, "ER86", false, 3, 200m },
                    { 16, 3, "ER86", false, 2, 200m },
                    { 15, 3, "ER86", false, 1, 200m },
                    { 14, 2, "KJ76", false, 6, 200m },
                    { 13, 2, "KJ76", false, 5, 200m },
                    { 12, 2, "KJ76", false, 4, 200m },
                    { 11, 2, "KJ76", false, 3, 200m },
                    { 10, 2, "KJ76", false, 2, 200m },
                    { 9, 2, "KJ76", false, 1, 200m },
                    { 8, 1, "QW11", false, 8, 200m },
                    { 7, 1, "QW11", false, 7, 200m },
                    { 6, 1, "QW11", false, 6, 200m },
                    { 5, 1, "QW11", false, 5, 200m },
                    { 4, 1, "QW11", false, 4, 200m },
                    { 3, 1, "QW11", false, 3, 200m },
                    { 2, 1, "QW11", false, 2, 200m },
                    { 1, 1, "QW11", false, 1, 200m },
                    { 19, 3, "ER86", false, 5, 200m },
                    { 20, 3, "ER86", false, 6, 200m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "FlightNumber",
                table: "Departures",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 8);
        }
    }
}

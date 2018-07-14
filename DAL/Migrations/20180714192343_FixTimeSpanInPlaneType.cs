using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportRESRfulApi.DAL.Migrations
{
    public partial class FixTimeSpanInPlaneType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceLife",
                table: "PlaneTypes");

            migrationBuilder.AddColumn<long>(
                name: "ServiceLifeInTicks",
                table: "PlaneTypes",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "Id",
                keyValue: 1,
                column: "DepartureTime",
                value: new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "Id",
                keyValue: 2,
                column: "DepartureTime",
                value: new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "Id",
                keyValue: 3,
                column: "DepartureTime",
                value: new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2018, 7, 13, 13, 22, 56, 640, DateTimeKind.Local), new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2018, 7, 13, 13, 22, 56, 640, DateTimeKind.Local), new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2018, 7, 13, 13, 22, 56, 640, DateTimeKind.Local), new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlaneTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ServiceLifeInTicks",
                value: 172800000000000L);

            migrationBuilder.UpdateData(
                table: "PlaneTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ServiceLifeInTicks",
                value: 216000000000000L);

            migrationBuilder.UpdateData(
                table: "PlaneTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ServiceLifeInTicks",
                value: 259200000000000L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceLifeInTicks",
                table: "PlaneTypes");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ServiceLife",
                table: "PlaneTypes",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "Id",
                keyValue: 1,
                column: "DepartureTime",
                value: new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "Id",
                keyValue: 2,
                column: "DepartureTime",
                value: new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "Id",
                keyValue: 3,
                column: "DepartureTime",
                value: new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2018, 7, 13, 13, 22, 56, 640, DateTimeKind.Local), new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2018, 7, 13, 13, 22, 56, 640, DateTimeKind.Local), new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2018, 7, 13, 13, 22, 56, 640, DateTimeKind.Local), new DateTime(2018, 7, 13, 8, 22, 56, 640, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "PlaneTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ServiceLife",
                value: new TimeSpan(200, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "PlaneTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ServiceLife",
                value: new TimeSpan(250, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "PlaneTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ServiceLife",
                value: new TimeSpan(300, 0, 0, 0, 0));
        }
    }
}

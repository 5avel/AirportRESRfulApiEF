using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportRESRfulApi.DAL.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Crews",
                columns: new[] { "Id", "DepartureId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

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

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "DepartureId", "Name", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 1, "dfg4456", new DateTime(1995, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, "QQWS1298", new DateTime(1995, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, "INB677", new DateTime(1995, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Pilots",
                columns: new[] { "Id", "Birthday", "CrewId", "Experience", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1987, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, "Ivan", "Ivanov" },
                    { 2, new DateTime(1987, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8, "Peta", "Penhjd" },
                    { 3, new DateTime(1987, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6, "Max", "Maximov" }
                });

            migrationBuilder.InsertData(
                table: "PlaneTypes",
                columns: new[] { "Id", "Capacity", "Model", "PlaneId", "Range", "Seats", "ServiceLife" },
                values: new object[,]
                {
                    { 1, 5000, "AN140", 1, 2345, 23, new TimeSpan(200, 0, 0, 0, 0) },
                    { 2, 5000, "IL235", 2, 2345, 23, new TimeSpan(250, 0, 0, 0, 0) },
                    { 3, 5000, "A380", 3, 2345, 23, new TimeSpan(300, 0, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Stewardesses",
                columns: new[] { "Id", "Birthday", "CrewId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1987, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ivana", "Ivanova" },
                    { 4, new DateTime(1987, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ira", "Ivanova" },
                    { 2, new DateTime(1987, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Petra", "Penhjd" },
                    { 5, new DateTime(1987, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Lena", "Penhjd" },
                    { 3, new DateTime(1987, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Maxima", "Maximova" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlaneTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PlaneTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PlaneTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stewardesses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stewardesses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stewardesses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stewardesses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stewardesses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Crews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: 3);

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
        }
    }
}

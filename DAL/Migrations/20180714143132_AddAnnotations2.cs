using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportRESRfulApi.DAL.Migrations
{
    public partial class AddAnnotations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FlightNumber",
                table: "Tickets",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Stewardesses",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Stewardesses",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "PlaneTypes",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Planes",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Pilots",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Pilots",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FlightNumber",
                table: "Flights",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DestinationPoint",
                table: "Flights",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeparturePoint",
                table: "Flights",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FlightNumber",
                table: "Tickets",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Stewardesses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Stewardesses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "PlaneTypes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Planes",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Pilots",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Pilots",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FlightNumber",
                table: "Flights",
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "DestinationPoint",
                table: "Flights",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DeparturePoint",
                table: "Flights",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

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

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaFit.DataAccess.Migrations
{
    public partial class AppointmentHours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentHour = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentTime", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2023, 7, 19, 15, 40, 59, 604, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 2,
                column: "VisitDate",
                value: new DateTime(2023, 7, 19, 15, 40, 59, 606, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 3,
                column: "VisitDate",
                value: new DateTime(2023, 7, 19, 15, 40, 59, 606, DateTimeKind.Local).AddTicks(3792));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentTime");

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2023, 7, 15, 5, 2, 13, 603, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 2,
                column: "VisitDate",
                value: new DateTime(2023, 7, 15, 5, 2, 13, 604, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 3,
                column: "VisitDate",
                value: new DateTime(2023, 7, 15, 5, 2, 13, 604, DateTimeKind.Local).AddTicks(8989));
        }
    }
}

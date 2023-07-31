using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaFit.DataAccess.Migrations
{
    public partial class AppoDeals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2(0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointment_Deal_DealId",
                        column: x => x.DealId,
                        principalTable: "Deal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2023, 7, 19, 16, 51, 49, 567, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 2,
                column: "VisitDate",
                value: new DateTime(2023, 7, 19, 16, 51, 49, 568, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 3,
                column: "VisitDate",
                value: new DateTime(2023, 7, 19, 16, 51, 49, 568, DateTimeKind.Local).AddTicks(4421));

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_DealId",
                table: "Appointment",
                column: "DealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2023, 7, 19, 16, 38, 49, 19, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 2,
                column: "VisitDate",
                value: new DateTime(2023, 7, 19, 16, 38, 49, 21, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 3,
                column: "VisitDate",
                value: new DateTime(2023, 7, 19, 16, 38, 49, 21, DateTimeKind.Local).AddTicks(630));
        }
    }
}

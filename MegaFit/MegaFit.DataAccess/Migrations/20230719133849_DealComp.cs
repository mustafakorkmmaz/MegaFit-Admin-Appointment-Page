using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaFit.DataAccess.Migrations
{
    public partial class DealComp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    AppointmentTimeId = table.Column<int>(type: "int", nullable: false),
                    TotalSession = table.Column<int>(type: "int", nullable: false),
                    AppointmentDayFirst = table.Column<string>(type: "varchar(20)", nullable: false),
                    AppointmentDaySecond = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deal_AppointmentTime_AppointmentTimeId",
                        column: x => x.AppointmentTimeId,
                        principalTable: "AppointmentTime",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Deal_CustomerVisit_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerVisit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Deal_Package_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Package",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Deal_AppointmentTimeId",
                table: "Deal",
                column: "AppointmentTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Deal_CustomerId",
                table: "Deal",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Deal_PackageId",
                table: "Deal",
                column: "PackageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deal");

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2023, 7, 19, 16, 4, 52, 738, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 2,
                column: "VisitDate",
                value: new DateTime(2023, 7, 19, 16, 4, 52, 740, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 3,
                column: "VisitDate",
                value: new DateTime(2023, 7, 19, 16, 4, 52, 740, DateTimeKind.Local).AddTicks(7554));
        }
    }
}

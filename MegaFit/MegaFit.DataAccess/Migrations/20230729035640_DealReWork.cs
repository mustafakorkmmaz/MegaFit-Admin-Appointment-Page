using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaFit.DataAccess.Migrations
{
    public partial class DealReWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Deal_DealId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Deal_CustomerVisit_CustomerId",
                table: "Deal");

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2023, 7, 29, 6, 56, 40, 397, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 2,
                column: "VisitDate",
                value: new DateTime(2023, 7, 29, 6, 56, 40, 399, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 3,
                column: "VisitDate",
                value: new DateTime(2023, 7, 29, 6, 56, 40, 399, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Deal_DealId",
                table: "Appointment",
                column: "DealId",
                principalTable: "Deal",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Deal_CustomerAssessment_CustomerId",
                table: "Deal",
                column: "CustomerId",
                principalTable: "CustomerAssessment",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Deal_DealId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Deal_CustomerAssessment_CustomerId",
                table: "Deal");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Deal_DealId",
                table: "Appointment",
                column: "DealId",
                principalTable: "Deal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deal_CustomerVisit_CustomerId",
                table: "Deal",
                column: "CustomerId",
                principalTable: "CustomerVisit",
                principalColumn: "Id");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaFit.DataAccess.Migrations
{
    public partial class TherapyDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2023, 7, 15, 4, 37, 40, 492, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 2,
                column: "VisitDate",
                value: new DateTime(2023, 7, 15, 4, 37, 40, 493, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 3,
                column: "VisitDate",
                value: new DateTime(2023, 7, 15, 4, 37, 40, 493, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.InsertData(
                table: "Therapy",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "GTOS" },
                    { 2, "Pilates" },
                    { 3, "Fizik Tedavi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Therapy",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Therapy",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Therapy",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 1,
                column: "VisitDate",
                value: new DateTime(2023, 7, 15, 4, 33, 29, 19, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 2,
                column: "VisitDate",
                value: new DateTime(2023, 7, 15, 4, 33, 29, 20, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 3,
                column: "VisitDate",
                value: new DateTime(2023, 7, 15, 4, 33, 29, 20, DateTimeKind.Local).AddTicks(8066));
        }
    }
}

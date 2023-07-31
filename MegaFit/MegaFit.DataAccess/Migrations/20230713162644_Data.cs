using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaFit.DataAccess.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CustomerAddress", "EmailAddress", "FirstName", "IdentityNumber", "LastName", "PhoneNumber" },
                values: new object[] { 1, "Uskudar", "mustafakorkmmaz@gmail.com", "Mustafa", "11102613645", "Korkmaz", "05343494123" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CustomerAddress", "EmailAddress", "FirstName", "IdentityNumber", "LastName", "PhoneNumber" },
                values: new object[] { 2, "Kartal", "mesutrizatunur@gmail.com", "Mesut Rıza", "313569752136", "Tunur", "05343494122" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CustomerAddress", "EmailAddress", "FirstName", "IdentityNumber", "LastName", "PhoneNumber" },
                values: new object[] { 3, "Maltepe", "yunusakbulut@gmail.com", "Yunus", "22269813645", "Akbulut", "05343494121" });

            migrationBuilder.InsertData(
                table: "CustomerVisit",
                columns: new[] { "Id", "Complaint", "CustomerId", "IsSick", "UsingDrugs", "VisitDate" },
                values: new object[] { 1, "Şikayet", 1, true, true, new DateTime(2023, 7, 13, 19, 26, 44, 214, DateTimeKind.Local).AddTicks(1756) });

            migrationBuilder.InsertData(
                table: "CustomerVisit",
                columns: new[] { "Id", "Complaint", "CustomerId", "IsSick", "UsingDrugs", "VisitDate" },
                values: new object[] { 2, "Test", 2, false, false, new DateTime(2023, 7, 13, 19, 26, 44, 215, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.InsertData(
                table: "CustomerVisit",
                columns: new[] { "Id", "Complaint", "CustomerId", "IsSick", "UsingDrugs", "VisitDate" },
                values: new object[] { 3, "Deneme", 3, true, false, new DateTime(2023, 7, 13, 19, 26, 44, 215, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.InsertData(
                table: "CustomerAssessment",
                columns: new[] { "Id", "Evaluation", "VisitId" },
                values: new object[] { 1, "Deneme", 1 });

            migrationBuilder.InsertData(
                table: "CustomerAssessment",
                columns: new[] { "Id", "Evaluation", "VisitId" },
                values: new object[] { 2, "Deneme", 2 });

            migrationBuilder.InsertData(
                table: "CustomerAssessment",
                columns: new[] { "Id", "Evaluation", "VisitId" },
                values: new object[] { 3, "Deneme", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerAssessment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerAssessment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CustomerAssessment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CustomerVisit",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

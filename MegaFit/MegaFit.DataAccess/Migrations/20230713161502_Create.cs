using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MegaFit.DataAccess.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(30)", nullable: false),
                    IdentityNumber = table.Column<string>(type: "varchar(20)", nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(30)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "varchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerVisit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Complaint = table.Column<string>(type: "varchar(1000)", nullable: false),
                    IsSick = table.Column<bool>(type: "bit", nullable: false),
                    UsingDrugs = table.Column<bool>(type: "bit", nullable: false),
                    VisitDate = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerVisit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerVisit_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerAssessment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    Evaluation = table.Column<string>(type: "varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAssessment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAssessment_CustomerVisit_VisitId",
                        column: x => x.VisitId,
                        principalTable: "CustomerVisit",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAssessment_VisitId",
                table: "CustomerAssessment",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerVisit_CustomerId",
                table: "CustomerVisit",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerAssessment");

            migrationBuilder.DropTable(
                name: "CustomerVisit");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}

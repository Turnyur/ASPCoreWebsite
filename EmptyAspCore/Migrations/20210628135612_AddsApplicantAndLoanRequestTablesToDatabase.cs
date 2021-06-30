using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmptyAspCore.Migrations
{
    public partial class AddsApplicantAndLoanRequestTablesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    LGA = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    State = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    Gender = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BVN = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    NIN = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DateTime", nullable: false, computedColumnSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoanRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "DateTime", nullable: false, computedColumnSql: "GetDate()"),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoanStatus = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "pending"),
                    LoanTypeId = table.Column<int>(type: "int", nullable: false),
                    ApplicantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoanRequests_Applicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "Applicants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanRequests_LoanTypes_LoanTypeId",
                        column: x => x.LoanTypeId,
                        principalTable: "LoanTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_BVN",
                table: "Applicants",
                column: "BVN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_NIN",
                table: "Applicants",
                column: "NIN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequests_ApplicantId",
                table: "LoanRequests",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanRequests_LoanTypeId",
                table: "LoanRequests",
                column: "LoanTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanRequests");

            migrationBuilder.DropTable(
                name: "Applicants");
        }
    }
}

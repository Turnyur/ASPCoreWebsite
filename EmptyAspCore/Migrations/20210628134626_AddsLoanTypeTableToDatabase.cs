using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmptyAspCore.Migrations
{
    public partial class AddsLoanTypeTableToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    Interest = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DateTime", nullable: false, computedColumnSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanTypes");
        }
    }
}

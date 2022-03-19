using Microsoft.EntityFrameworkCore.Migrations;

namespace Pharmacyp.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "CompanydNumber",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "CompanyNumber",
                table: "Companies",
                type: "varchar(16)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyNumber",
                table: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "ExpirationDate",
                table: "Medicines",
                type: "varchar(5)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanydNumber",
                table: "Companies",
                type: "varchar(16)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExpirationDate",
                table: "Companies",
                type: "varchar(5)",
                nullable: false,
                defaultValue: "");
        }
    }
}

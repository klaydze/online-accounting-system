using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Infrastructure.Migrations
{
    public partial class AddedBackCodeInAccountType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nature",
                table: "AccountTypes");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "AccountTypes",
                type: "varchar(5)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "AccountTypes");

            migrationBuilder.AddColumn<string>(
                name: "Nature",
                table: "AccountTypes",
                type: "varchar(6)",
                nullable: true);
        }
    }
}

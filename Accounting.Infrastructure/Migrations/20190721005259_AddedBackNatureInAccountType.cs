using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Infrastructure.Migrations
{
    public partial class AddedBackNatureInAccountType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nature",
                table: "AccountTypes",
                type: "varchar(6)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nature",
                table: "AccountTypes");
        }
    }
}

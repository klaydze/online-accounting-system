using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Infrastructure.Migrations
{
    public partial class AddedCompanyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(200)", nullable: true),
                    Address1 = table.Column<string>(type: "varchar(50)", nullable: true),
                    Address2 = table.Column<string>(type: "varchar(50)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(15)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(15)", nullable: true),
                    TIN = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}

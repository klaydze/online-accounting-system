using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Infrastructure.Migrations
{
    public partial class ModifiedLRandARSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalesAccountID",
                table: "ReceivableSettings");

            migrationBuilder.AddColumn<DateTime>(
                name: "EffectivityDate",
                table: "ReceivableSettings",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IntOutright",
                table: "ReceivableSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InterestMode",
                table: "ReceivableSettings",
                type: "varchar(15)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Term",
                table: "ReceivableSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "WithRebates",
                table: "ReceivableSettings",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EffectivityDate",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "IntOutright",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "InterestMode",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "Term",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "WithRebates",
                table: "ReceivableSettings");

            migrationBuilder.AddColumn<Guid>(
                name: "SalesAccountID",
                table: "ReceivableSettings",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}

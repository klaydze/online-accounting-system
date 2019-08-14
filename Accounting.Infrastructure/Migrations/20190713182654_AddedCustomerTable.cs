using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Infrastructure.Migrations
{
    public partial class AddedCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ARSettingsID",
                table: "Receivables");

            migrationBuilder.DropColumn(
                name: "LRSettingsID",
                table: "Receivables");

            migrationBuilder.AddColumn<Guid>(
                name: "SalesAccountID",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AllowMultiple",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Eligibility",
                table: "ReceivableSettings",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LLAccountID",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LPAccountID",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LRAccountID",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MemberOnly",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MinPayment",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinPaymentScheme",
                table: "ReceivableSettings",
                type: "varchar(5)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "ReceivableSettings",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceivedFromA",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceivedFromB",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceivedToA",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceivedToB",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReleasedDayA",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReleasedDayB",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequiredCoMaker",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Requirements",
                table: "ReceivableSettings",
                type: "varchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UILAccountID",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "WithCoMaker",
                table: "ReceivableSettings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "ReceivableSettings",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "RSettingID",
                table: "Receivables",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(nullable: false),
                    CustomerNo = table.Column<string>(type: "varchar(8)", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastName = table.Column<string>(type: "varchar(30)", nullable: true),
                    FirstName = table.Column<string>(type: "varchar(30)", nullable: true),
                    MiddleName = table.Column<string>(type: "varchar(30)", nullable: true),
                    Address1 = table.Column<string>(type: "varchar(50)", nullable: true),
                    Address2 = table.Column<string>(type: "varchar(50)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(15)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(15)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropColumn(
                name: "SalesAccountID",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "AllowMultiple",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "Eligibility",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "LLAccountID",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "LPAccountID",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "LRAccountID",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "MemberOnly",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "MinPayment",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "MinPaymentScheme",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "ReceivedFromA",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "ReceivedFromB",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "ReceivedToA",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "ReceivedToB",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "ReleasedDayA",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "ReleasedDayB",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "RequiredCoMaker",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "Requirements",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "UILAccountID",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "WithCoMaker",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "ReceivableSettings");

            migrationBuilder.DropColumn(
                name: "RSettingID",
                table: "Receivables");

            migrationBuilder.AddColumn<Guid>(
                name: "ARSettingsID",
                table: "Receivables",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LRSettingsID",
                table: "Receivables",
                nullable: true);
        }
    }
}

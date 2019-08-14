using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Infrastructure.Migrations
{
    public partial class UpdatedNatureLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nature",
                table: "AccountTypes",
                type: "varchar(6)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ChartOfAccounts",
                columns: table => new
                {
                    AccountID = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(5)", nullable: true),
                    Title = table.Column<string>(type: "varchar(100)", nullable: true),
                    Description = table.Column<string>(type: "varchar(300)", nullable: true),
                    Nature = table.Column<string>(type: "varchar(6)", nullable: true),
                    GroupID = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    AccountTypeID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartOfAccounts", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_ChartOfAccounts_AccountTypes_AccountTypeID",
                        column: x => x.AccountTypeID,
                        principalTable: "AccountTypes",
                        principalColumn: "AccountTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfitCentres",
                columns: table => new
                {
                    ProfitCentreID = table.Column<Guid>(nullable: false),
                    ProfitCentreName = table.Column<string>(type: "varchar(200)", nullable: true),
                    ContactNo = table.Column<string>(type: "varchar(15)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(15)", nullable: true),
                    Address1 = table.Column<string>(type: "varchar(50)", nullable: true),
                    Address2 = table.Column<string>(type: "varchar(50)", nullable: true),
                    Address3 = table.Column<string>(type: "varchar(50)", nullable: true),
                    TradeName = table.Column<string>(type: "varchar(100)", nullable: true),
                    ProfitCentreType = table.Column<string>(type: "varchar(20)", nullable: true),
                    CompanyID = table.Column<Guid>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfitCentres", x => x.ProfitCentreID);
                    table.ForeignKey(
                        name: "FK_ProfitCentres_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProfitCentreAccounts",
                columns: table => new
                {
                    ProfitCentreID = table.Column<Guid>(nullable: false),
                    AccountID = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfitCentreAccounts", x => x.ProfitCentreID);
                    table.ForeignKey(
                        name: "FK_ProfitCentreAccounts_ChartOfAccounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "ChartOfAccounts",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfitCentreAccounts_ProfitCentres_ProfitCentreID",
                        column: x => x.ProfitCentreID,
                        principalTable: "ProfitCentres",
                        principalColumn: "ProfitCentreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChartOfAccounts_AccountTypeID",
                table: "ChartOfAccounts",
                column: "AccountTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfitCentreAccounts_AccountID",
                table: "ProfitCentreAccounts",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_ProfitCentres_CompanyID",
                table: "ProfitCentres",
                column: "CompanyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfitCentreAccounts");

            migrationBuilder.DropTable(
                name: "ChartOfAccounts");

            migrationBuilder.DropTable(
                name: "ProfitCentres");

            migrationBuilder.AlterColumn<string>(
                name: "Nature",
                table: "AccountTypes",
                type: "varchar(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldNullable: true);
        }
    }
}

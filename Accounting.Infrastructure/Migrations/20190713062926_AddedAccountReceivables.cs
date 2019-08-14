using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accounting.Infrastructure.Migrations
{
    public partial class AddedAccountReceivables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfitCentreAccounts",
                table: "ProfitCentreAccounts");

            migrationBuilder.AddColumn<Guid>(
                name: "PCAccountID",
                table: "ProfitCentreAccounts",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfitCentreAccounts",
                table: "ProfitCentreAccounts",
                column: "PCAccountID");

            migrationBuilder.CreateTable(
                name: "JournalDetails",
                columns: table => new
                {
                    JournalDetailID = table.Column<Guid>(nullable: false),
                    JournalID = table.Column<Guid>(nullable: false),
                    PCAccountID = table.Column<Guid>(nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Nature = table.Column<string>(type: "varchar(6)", nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalDetails", x => x.JournalDetailID);
                });

            migrationBuilder.CreateTable(
                name: "Journals",
                columns: table => new
                {
                    JournalID = table.Column<Guid>(nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Particular = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "varchar(15)", nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    CashReceiptNo = table.Column<string>(type: "varchar(15)", nullable: true),
                    Payee = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journals", x => x.JournalID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentSchedules",
                columns: table => new
                {
                    PaymentScheduleID = table.Column<Guid>(nullable: false),
                    ReceivableID = table.Column<Guid>(nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Type = table.Column<string>(type: "varchar(15)", nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    PCAccountID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSchedules", x => x.PaymentScheduleID);
                });

            migrationBuilder.CreateTable(
                name: "Receivables",
                columns: table => new
                {
                    ReceivableID = table.Column<Guid>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MaturityDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Term = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Amortization = table.Column<double>(nullable: false),
                    Balance = table.Column<double>(nullable: false),
                    Status = table.Column<string>(type: "varchar(15)", nullable: true),
                    Remarks = table.Column<string>(type: "varchar(1000)", nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    CustomerID = table.Column<Guid>(nullable: true),
                    ARSettingsID = table.Column<Guid>(nullable: true),
                    MemberID = table.Column<Guid>(nullable: true),
                    LRSettingsID = table.Column<Guid>(nullable: true),
                    LoanApplicationID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receivables", x => x.ReceivableID);
                });

            migrationBuilder.CreateTable(
                name: "ReceivableSettings",
                columns: table => new
                {
                    RSettingID = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(5)", nullable: true),
                    Description = table.Column<string>(type: "varchar(100)", nullable: true),
                    PaymentMode = table.Column<string>(type: "varchar(15)", nullable: true),
                    PenaltyMode = table.Column<string>(type: "varchar(15)", nullable: true),
                    InterestRate = table.Column<double>(nullable: false),
                    PenaltyRate = table.Column<double>(nullable: false),
                    SalesAccountID = table.Column<Guid>(nullable: false),
                    PCAccountID = table.Column<Guid>(nullable: false),
                    IntAccountID = table.Column<Guid>(nullable: false),
                    PenaltyAccountID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivableSettings", x => x.RSettingID);
                });

            migrationBuilder.CreateTable(
                name: "ReceivableTransactionDetails",
                columns: table => new
                {
                    ReceivableID = table.Column<Guid>(nullable: false),
                    ReceivableTransactionID = table.Column<Guid>(nullable: false),
                    JournalDetailID = table.Column<Guid>(nullable: false),
                    PaymentScheduleID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivableTransactionDetails", x => x.ReceivableID);
                });

            migrationBuilder.CreateTable(
                name: "ReceivableTransactions",
                columns: table => new
                {
                    ReceivableTransactionID = table.Column<Guid>(nullable: false),
                    TransationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReceivableID = table.Column<Guid>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    JournalID = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedBy = table.Column<Guid>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivableTransactions", x => x.ReceivableTransactionID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfitCentreAccounts_ProfitCentreID",
                table: "ProfitCentreAccounts",
                column: "ProfitCentreID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JournalDetails");

            migrationBuilder.DropTable(
                name: "Journals");

            migrationBuilder.DropTable(
                name: "PaymentSchedules");

            migrationBuilder.DropTable(
                name: "Receivables");

            migrationBuilder.DropTable(
                name: "ReceivableSettings");

            migrationBuilder.DropTable(
                name: "ReceivableTransactionDetails");

            migrationBuilder.DropTable(
                name: "ReceivableTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProfitCentreAccounts",
                table: "ProfitCentreAccounts");

            migrationBuilder.DropIndex(
                name: "IX_ProfitCentreAccounts_ProfitCentreID",
                table: "ProfitCentreAccounts");

            migrationBuilder.DropColumn(
                name: "PCAccountID",
                table: "ProfitCentreAccounts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProfitCentreAccounts",
                table: "ProfitCentreAccounts",
                column: "ProfitCentreID");
        }
    }
}

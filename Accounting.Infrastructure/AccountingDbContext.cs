using Accounting.Domain.Entities;
using Accounting.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure
{
    public class AccountingDbContext : DbContext
    {
        //For Migration
        public DbSet<Company> Companies { get; set; }
        public DbSet<ProfitCentre> ProfitCentres { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<ChartOfAccount> ChartOfAccounts { get; set; }
        public DbSet<ProfitCentreAccount> ProfitCentreAccounts { get; set; }
        public DbSet<ReceivableSetting> ReceivableSettings { get; set; }
        public DbSet<ARSetting> ARSettings { get; set; }
        public DbSet<LRSetting> LRSettings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<JournalDetail> JournalDetails { get; set; }
        public DbSet<CashReceiptJournal> CashReceiptJournals { get; set; }
        public DbSet<Receivable> Receivables { get; set; }
        public DbSet<AccountsReceivable> AccountsReceivables { get; set; }
        public DbSet<LoansReceivable> LoansReceivables { get; set; }
        public DbSet<PaymentSchedule> PaymentSchedules { get; set; }
        public DbSet<ReceivableTransaction> ReceivableTransactions { get; set; }
        public DbSet<ReceivableTransactionDetail> ReceivableTransactionDetails { get; set; }

        //For scaffolding
        //public DbSet<AccountTypeModel> AccountTypes { get; set; }
        //public DbSet<CompanyModel> Companies { get; set; }
        //public DbSet<ProfitCentreModel> ProfitCentres { get; set; }

        public AccountingDbContext(DbContextOptions options) : base(options)
        { }
    }
}

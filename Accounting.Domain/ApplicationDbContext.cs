using Accounting.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using System.Linq;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain
{
    public class ApplicationDbContext : DbContext
    {
        public Guid CurrentUserId { get; set; }

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

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }
        public async Task<int> SaveChangesAsync()
        {
            UpdateAuditEntities();
            return await base.SaveChangesAsync();
        }

        private void UpdateAuditEntities()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                var entity = (IAuditableEntity)entry.Entity;
                DateTime now = DateTime.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedDate = now;
                    entity.CreatedBy = CurrentUserId;
                }
                else
                {
                    base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                    base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                }

                entity.UpdatedDate = now;
                entity.UpdatedBy = CurrentUserId;
            }
        }
    }
}

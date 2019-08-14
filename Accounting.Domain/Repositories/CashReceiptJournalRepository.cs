using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class CashReceiptJournalRepository : Repository<CashReceiptJournal>, ICashReceiptJournalRepository
    {
        public CashReceiptJournalRepository(ApplicationDbContext context) 
            : base(context)
        {            
        }
    }
}

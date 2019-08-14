using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface ICashReceiptJournalService
    {
        Task CreateAsync(CashReceiptJournalModel model);

        Task<CashReceiptJournalModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<CashReceiptJournalModel>> GetAllAsync();

        Task UpdateAsync(CashReceiptJournalModel model);

        Task DeleteAsync(CashReceiptJournalModel model);

    }
}

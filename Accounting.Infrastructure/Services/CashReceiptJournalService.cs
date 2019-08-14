using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class CashReceiptJournalService : ICashReceiptJournalService
    {
        private readonly ICashReceiptJournalRepository cashReceiptJournal;

        public CashReceiptJournalService(ICashReceiptJournalRepository cashReceiptJournal)
            => this.cashReceiptJournal = cashReceiptJournal;

        public async Task CreateAsync(CashReceiptJournalModel model)
        {
            cashReceiptJournal.Create(AutoMapper.Mapper.Map<CashReceiptJournal>(model));
            await cashReceiptJournal.SaveAsync();
        }

        public async Task DeleteAsync(CashReceiptJournalModel model)
        {
            this.cashReceiptJournal.Delete(AutoMapper.Mapper.Map<CashReceiptJournal>(model));
            await cashReceiptJournal.SaveAsync();
        }

        public async Task<IEnumerable<CashReceiptJournalModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<CashReceiptJournalModel>>(await cashReceiptJournal.GetAllAsync());

        public async Task<CashReceiptJournalModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<CashReceiptJournalModel>(await cashReceiptJournal.GetByIDAsync(id));

        public async Task UpdateAsync(CashReceiptJournalModel model)
        {
            cashReceiptJournal.Update(AutoMapper.Mapper.Map<CashReceiptJournal>(model));
            await cashReceiptJournal.SaveAsync();
        }
    }
}

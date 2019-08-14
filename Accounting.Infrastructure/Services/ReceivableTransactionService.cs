using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class ReceivableTransactionService : IReceivableTransactionService
    {
        private readonly IReceivableTransactionRepository receivableTransaction;

        public ReceivableTransactionService(IReceivableTransactionRepository receivableTransaction)
            => this.receivableTransaction = receivableTransaction;

        public async Task CreateAsync(ReceivableTransactionModel model)
        {
            receivableTransaction.Create(AutoMapper.Mapper.Map<ReceivableTransaction>(model));
            await receivableTransaction.SaveAsync();
        }

        public async Task DeleteAsync(ReceivableTransactionModel model)
        {
            this.receivableTransaction.Delete(AutoMapper.Mapper.Map<ReceivableTransaction>(model));
            await receivableTransaction.SaveAsync();
        }

        public async Task<IEnumerable<ReceivableTransactionModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<ReceivableTransactionModel>>(await receivableTransaction.GetAllAsync());

        public async Task<ReceivableTransactionModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<ReceivableTransactionModel>(await receivableTransaction.GetByIDAsync(id));

        public async Task UpdateAsync(ReceivableTransactionModel model)
        {
            receivableTransaction.Update(AutoMapper.Mapper.Map<ReceivableTransaction>(model));
            await receivableTransaction.SaveAsync();
        }
    }
}

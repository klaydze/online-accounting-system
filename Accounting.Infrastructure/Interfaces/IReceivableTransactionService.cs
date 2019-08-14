using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface IReceivableTransactionService
    {
        Task CreateAsync(ReceivableTransactionModel model);

        Task<ReceivableTransactionModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ReceivableTransactionModel>> GetAllAsync();

        Task UpdateAsync(ReceivableTransactionModel model);

        Task DeleteAsync(ReceivableTransactionModel model);

    }
}

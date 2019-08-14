using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface IReceivableTransactionDetailService
    {
        Task CreateAsync(ReceivableTransactionDetailModel model);

        Task<ReceivableTransactionDetailModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ReceivableTransactionDetailModel>> GetAllAsync();

        Task UpdateAsync(ReceivableTransactionDetailModel model);

        Task DeleteAsync(ReceivableTransactionDetailModel model);

    }
}

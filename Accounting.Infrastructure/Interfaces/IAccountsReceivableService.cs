using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface IAccountsReceivableService
    {
        Task CreateAsync(AccountsReceivableModel model);

        Task<AccountsReceivableModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<AccountsReceivableModel>> GetAllAsync();

        Task UpdateAsync(AccountsReceivableModel model);

        Task DeleteAsync(AccountsReceivableModel model);

    }
}

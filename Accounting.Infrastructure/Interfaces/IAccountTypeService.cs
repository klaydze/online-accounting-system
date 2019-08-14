using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface IAccountTypeService
    {
        Task CreateAsync(AccountTypeModel model);

        Task<AccountTypeModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<AccountTypeModel>> GetAllAsync();

        Task UpdateAsync(AccountTypeModel model);

        Task DeleteAsync(AccountTypeModel model);

    }
}

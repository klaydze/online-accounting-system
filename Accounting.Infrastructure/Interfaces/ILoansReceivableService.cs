using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface ILoansReceivableService
    {
        Task CreateAsync(LoansReceivableModel model);

        Task<LoansReceivableModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<LoansReceivableModel>> GetAllAsync();

        Task UpdateAsync(LoansReceivableModel model);

        Task DeleteAsync(LoansReceivableModel model);

    }
}

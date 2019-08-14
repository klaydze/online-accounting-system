using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface IProfitCentreAccountService
    {
        Task CreateAsync(ProfitCentreAccountModel model);

        Task<ProfitCentreAccountModel> GetByIDAsync(Guid? profitCentreID, Guid? accountID);
        Task<IEnumerable<ProfitCentreAccountModel>> GetAllAsync();

        Task UpdateAsync(ProfitCentreAccountModel model);

        Task DeleteAsync(ProfitCentreAccountModel model);

    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface IChartOfAccountService
    {
        Task CreateAsync(ChartOfAccountModel model);

        Task<ChartOfAccountModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ChartOfAccountModel>> GetAllAsync();

        Task UpdateAsync(ChartOfAccountModel model);

        Task DeleteAsync(ChartOfAccountModel model);

    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface IProfitCentreService
    {
        Task CreateAsync(ProfitCentreModel model);

        Task<ProfitCentreModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ProfitCentreModel>> GetAllAsync();

        Task UpdateAsync(ProfitCentreModel model);

        Task DeleteAsync(ProfitCentreModel model);

    }
}

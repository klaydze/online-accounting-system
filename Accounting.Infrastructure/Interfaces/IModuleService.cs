using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface IModuleService
    {
        Task CreateAsync(ModuleModel model);

        Task<ModuleModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ModuleModel>> GetAllAsync();

        Task UpdateAsync(ModuleModel model);

        Task DeleteAsync(ModuleModel model);

    }
}

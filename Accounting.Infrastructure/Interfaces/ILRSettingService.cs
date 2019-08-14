using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface ILRSettingService
    {
        Task CreateAsync(LRSettingModel model);

        Task<LRSettingModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<LRSettingModel>> GetAllAsync();

        Task UpdateAsync(LRSettingModel model);

        Task DeleteAsync(LRSettingModel model);

    }
}

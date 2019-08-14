using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface IARSettingService
    {
        Task CreateAsync(ARSettingModel model);

        Task<ARSettingModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<ARSettingModel>> GetAllAsync();

        Task UpdateAsync(ARSettingModel model);

        Task DeleteAsync(ARSettingModel model);

    }
}

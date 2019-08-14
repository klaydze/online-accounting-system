using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface IUserLevelService
    {
        Task CreateAsync(UserLevelModel model);

        Task<UserLevelModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<UserLevelModel>> GetAllAsync();

        Task UpdateAsync(UserLevelModel model);

        Task DeleteAsync(UserLevelModel model);

    }
}

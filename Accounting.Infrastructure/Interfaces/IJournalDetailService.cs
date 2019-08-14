using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface IJournalDetailService
    {
        Task CreateAsync(JournalDetailModel model);

        Task<JournalDetailModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<JournalDetailModel>> GetAllAsync();

        Task UpdateAsync(JournalDetailModel model);

        Task DeleteAsync(JournalDetailModel model);

    }
}

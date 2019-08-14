using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface ICompanyService
    {
        Task CreateAsync(CompanyModel model);

        Task<CompanyModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<CompanyModel>> GetAllAsync();

        Task UpdateAsync(CompanyModel model);

        Task DeleteAsync(CompanyModel model);

    }
}

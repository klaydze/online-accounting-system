using Accounting.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Accounting.Domain.Interfaces
{
    public interface IProfitCentreAccountRepository : IRepository<ProfitCentreAccount>
    {
        Task<ProfitCentreAccount> GetByIDAsync(Guid? profitCentreID, Guid? accountID);
    }
}

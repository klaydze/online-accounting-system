using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Accounting.Domain.Repositories
{
    public class ProfitCentreAccountRepository : Repository<ProfitCentreAccount>, IProfitCentreAccountRepository
    {
        public ProfitCentreAccountRepository(ApplicationDbContext context) 
            : base(context)
        {
        }

        public async Task<ProfitCentreAccount> GetByIDAsync(Guid? profitCentreID, Guid? accountID)
        {
            return await Context.Set<ProfitCentreAccount>()
                .Include(a => a.ProfitCentre)
                .Include(a => a.AccountID)
                .FirstOrDefaultAsync(a => a.ProfitCentreID == profitCentreID && a.AccountID== accountID);
        }
    }
}

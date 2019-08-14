using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting.Domain.Repositories
{
    public class ChartOfAccountRepository : Repository<ChartOfAccount>, IChartOfAccountRepository
    {
        public ChartOfAccountRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public override async Task<ChartOfAccount> GetByIDAsync(Guid? id)
        {
            return await Context.Set<ChartOfAccount>()
                .Include(a => a.accountType)
                .FirstOrDefaultAsync(a => a.AccountID == id);
        }

        public override async Task<IEnumerable<ChartOfAccount>> GetAllAsync()
        {
            return await Context.Set<ChartOfAccount>().OrderBy(b => b.Code).ToListAsync();
        }
    }
}
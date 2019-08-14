using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Accounting.Domain.Repositories
{
    public class ProfitCentreRepository : Repository<ProfitCentre>, IProfitCentreRepository
    {
        public ProfitCentreRepository(ApplicationDbContext context) 
            : base(context)
        {
        }

        public override async Task<ProfitCentre> GetByIDAsync(Guid? id)
        {
            return await Context.Set<ProfitCentre>()
                .Include(a => a.Company)
                .FirstOrDefaultAsync(a => a.ProfitCentreID == id);
        }
    }
}

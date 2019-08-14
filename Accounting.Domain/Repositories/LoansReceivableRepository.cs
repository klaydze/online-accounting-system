using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class LoansReceivableRepository : Repository<LoansReceivable>, ILoansReceivableRepository
    {
        public LoansReceivableRepository(ApplicationDbContext context) 
            : base(context)
        {            
        }
    }
}

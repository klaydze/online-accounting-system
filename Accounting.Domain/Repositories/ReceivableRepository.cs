using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class ReceivableRepository : Repository<Receivable>, IReceivableRepository
    {
        public ReceivableRepository(ApplicationDbContext context) 
            : base(context)
        {            
        }
    }
}

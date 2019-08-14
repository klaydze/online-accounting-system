using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class ReceivableTransactionDetailRepository : Repository<ReceivableTransactionDetail>, IReceivableTransactionDetailRepository
    {
        public ReceivableTransactionDetailRepository(ApplicationDbContext context) 
            : base(context)
        {            
        }
    }
}

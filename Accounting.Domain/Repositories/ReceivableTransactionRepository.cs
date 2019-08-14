using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class ReceivableTransactionRepository : Repository<ReceivableTransaction>, IReceivableTransactionRepository
    {
        public ReceivableTransactionRepository(ApplicationDbContext context) 
            : base(context)
        {            
        }
    }
}

using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class AccountsReceivableRepository : Repository<AccountsReceivable>, IAccountsReceivableRepository
    {
        public AccountsReceivableRepository(ApplicationDbContext context) 
            : base(context)
        {            
        }
    }
}

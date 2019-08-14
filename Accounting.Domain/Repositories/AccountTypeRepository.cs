using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class AccountTypeRepository : Repository<AccountType>, IAccountTypeRepository
    {
        public AccountTypeRepository(ApplicationDbContext context) 
            : base(context)
        {           
        }
    }
}

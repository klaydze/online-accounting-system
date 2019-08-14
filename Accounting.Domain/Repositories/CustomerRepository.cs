using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) 
            : base(context)
        {            
        }
    }
}

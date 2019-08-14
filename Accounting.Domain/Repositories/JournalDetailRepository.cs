using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class JournalDetailRepository : Repository<JournalDetail>, IJournalDetailRepository
    {
        public JournalDetailRepository(ApplicationDbContext context) 
            : base(context)
        {            
        }
    }
}

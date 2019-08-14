using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class UserLevelRepository : Repository<UserLevel>, IUserLevelRepository
    {
        public UserLevelRepository(ApplicationDbContext context) 
            : base(context)
        {           
        }
    }
}

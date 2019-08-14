using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class LRSettingRepository : Repository<LRSetting>, ILRSettingRepository
    {
        public LRSettingRepository(ApplicationDbContext context) 
            : base(context)
        {            
        }
    }
}

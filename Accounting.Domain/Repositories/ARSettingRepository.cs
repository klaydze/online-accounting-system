using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class ARSettingRepository : Repository<ARSetting>, IARSettingRepository
    {
        public ARSettingRepository(ApplicationDbContext context) 
            : base(context)
        {            
        }
    }
}

using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class PaymentScheduleRepository : Repository<PaymentSchedule>, IPaymentScheduleRepository
    {
        public PaymentScheduleRepository(ApplicationDbContext context) 
            : base(context)
        {            
        }
    }
}

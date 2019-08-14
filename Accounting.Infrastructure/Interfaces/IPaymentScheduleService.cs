using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Accounting.Infrastructure.Models;

namespace Accounting.Infrastructure.Interfaces
{
    public interface IPaymentScheduleService
    {
        Task CreateAsync(PaymentScheduleModel model);

        Task<PaymentScheduleModel> GetByIDAsync(Guid? id);
        Task<IEnumerable<PaymentScheduleModel>> GetAllAsync();

        Task UpdateAsync(PaymentScheduleModel model);

        Task DeleteAsync(PaymentScheduleModel model);

    }
}

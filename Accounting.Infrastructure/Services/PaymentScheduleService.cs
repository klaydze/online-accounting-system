using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class PaymentScheduleService : IPaymentScheduleService
    {
        private readonly IPaymentScheduleRepository paymentSchedule;

        public PaymentScheduleService(IPaymentScheduleRepository paymentSchedule)
            => this.paymentSchedule = paymentSchedule;

        public async Task CreateAsync(PaymentScheduleModel model)
        {
            paymentSchedule.Create(AutoMapper.Mapper.Map<PaymentSchedule>(model));
            await paymentSchedule.SaveAsync();
        }

        public async Task DeleteAsync(PaymentScheduleModel model)
        {
            this.paymentSchedule.Delete(AutoMapper.Mapper.Map<PaymentSchedule>(model));
            await paymentSchedule.SaveAsync();
        }

        public async Task<IEnumerable<PaymentScheduleModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<PaymentScheduleModel>>(await paymentSchedule.GetAllAsync());

        public async Task<PaymentScheduleModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<PaymentScheduleModel>(await paymentSchedule.GetByIDAsync(id));

        public async Task UpdateAsync(PaymentScheduleModel model)
        {
            paymentSchedule.Update(AutoMapper.Mapper.Map<PaymentSchedule>(model));
            await paymentSchedule.SaveAsync();
        }
    }
}

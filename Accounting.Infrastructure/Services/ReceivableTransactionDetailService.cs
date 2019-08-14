using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class ReceivableTransactionDetailService : IReceivableTransactionDetailService
    {
        private readonly IReceivableTransactionDetailRepository receivableTransactionDetail;

        public ReceivableTransactionDetailService(IReceivableTransactionDetailRepository receivableTransactionDetail)
            => this.receivableTransactionDetail = receivableTransactionDetail;

        public async Task CreateAsync(ReceivableTransactionDetailModel model)
        {
            receivableTransactionDetail.Create(AutoMapper.Mapper.Map<ReceivableTransactionDetail>(model));
            await receivableTransactionDetail.SaveAsync();
        }

        public async Task DeleteAsync(ReceivableTransactionDetailModel model)
        {
            this.receivableTransactionDetail.Delete(AutoMapper.Mapper.Map<ReceivableTransactionDetail>(model));
            await receivableTransactionDetail.SaveAsync();
        }

        public async Task<IEnumerable<ReceivableTransactionDetailModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<ReceivableTransactionDetailModel>>(await receivableTransactionDetail.GetAllAsync());

        public async Task<ReceivableTransactionDetailModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<ReceivableTransactionDetailModel>(await receivableTransactionDetail.GetByIDAsync(id));

        public async Task UpdateAsync(ReceivableTransactionDetailModel model)
        {
            receivableTransactionDetail.Update(AutoMapper.Mapper.Map<ReceivableTransactionDetail>(model));
            await receivableTransactionDetail.SaveAsync();
        }
    }
}

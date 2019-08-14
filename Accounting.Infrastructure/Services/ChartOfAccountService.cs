using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class ChartOfAccountService : IChartOfAccountService
    {
        private readonly IChartOfAccountRepository ChartOfAccount;

        public ChartOfAccountService(IChartOfAccountRepository ChartOfAccount)
            => this.ChartOfAccount = ChartOfAccount;

        public async Task CreateAsync(ChartOfAccountModel model)
        {
            ChartOfAccount.Create(AutoMapper.Mapper.Map<ChartOfAccount>(model));
            await ChartOfAccount.SaveAsync();
        }

        public async Task DeleteAsync(ChartOfAccountModel model)
        {
            this.ChartOfAccount.Delete(AutoMapper.Mapper.Map<ChartOfAccount>(model));
            await ChartOfAccount.SaveAsync();
        }

        public async Task<IEnumerable<ChartOfAccountModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<ChartOfAccountModel>>(await ChartOfAccount.GetAllAsync());

        public async Task<ChartOfAccountModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<ChartOfAccountModel>(await ChartOfAccount.GetByIDAsync(id));

        public async Task UpdateAsync(ChartOfAccountModel model)
        {
            ChartOfAccount.Update(AutoMapper.Mapper.Map<ChartOfAccount>(model));
            await ChartOfAccount.SaveAsync();
        }
    }
}

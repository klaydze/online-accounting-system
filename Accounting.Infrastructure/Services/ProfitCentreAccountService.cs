using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class ProfitCentreAccountService : IProfitCentreAccountService
    {
        private readonly IProfitCentreAccountRepository ProfitCentreAccount;

        public ProfitCentreAccountService(IProfitCentreAccountRepository ProfitCentreAccount)
            => this.ProfitCentreAccount = ProfitCentreAccount;

        public async Task CreateAsync(ProfitCentreAccountModel model)
        {
            ProfitCentreAccount.Create(AutoMapper.Mapper.Map<ProfitCentreAccount>(model));
            await ProfitCentreAccount.SaveAsync();
        }

        public async Task DeleteAsync(ProfitCentreAccountModel model)
        {
            this.ProfitCentreAccount.Delete(AutoMapper.Mapper.Map<ProfitCentreAccount>(model));
            await ProfitCentreAccount.SaveAsync();
        }

        public async Task<IEnumerable<ProfitCentreAccountModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<ProfitCentreAccountModel>>(await ProfitCentreAccount.GetAllAsync());

        public async Task<ProfitCentreAccountModel> GetByIDAsync(Guid? profitCentreID, Guid? accountID)
            => AutoMapper.Mapper.Map<ProfitCentreAccountModel>(await ProfitCentreAccount.GetByIDAsync(profitCentreID, accountID));

        public async Task UpdateAsync(ProfitCentreAccountModel model)
        {
            ProfitCentreAccount.Update(AutoMapper.Mapper.Map<ProfitCentreAccount>(model));
            await ProfitCentreAccount.SaveAsync();
        }
    }
}

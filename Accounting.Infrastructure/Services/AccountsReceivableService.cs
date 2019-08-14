using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class AccountsReceivableService : IAccountsReceivableService
    {
        private readonly IAccountsReceivableRepository accountsReceivable;

        public AccountsReceivableService(IAccountsReceivableRepository accountsReceivable)
            => this.accountsReceivable = accountsReceivable;

        public async Task CreateAsync(AccountsReceivableModel model)
        {
            accountsReceivable.Create(AutoMapper.Mapper.Map<AccountsReceivable>(model));
            await accountsReceivable.SaveAsync();
        }

        public async Task DeleteAsync(AccountsReceivableModel model)
        {
            this.accountsReceivable.Delete(AutoMapper.Mapper.Map<AccountsReceivable>(model));
            await accountsReceivable.SaveAsync();
        }

        public async Task<IEnumerable<AccountsReceivableModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<AccountsReceivableModel>>(await accountsReceivable.GetAllAsync());

        public async Task<AccountsReceivableModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<AccountsReceivableModel>(await accountsReceivable.GetByIDAsync(id));

        public async Task UpdateAsync(AccountsReceivableModel model)
        {
            accountsReceivable.Update(AutoMapper.Mapper.Map<AccountsReceivable>(model));
            await accountsReceivable.SaveAsync();
        }
    }
}

using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class AccountTypeService : IAccountTypeService
    {
        private readonly IAccountTypeRepository accountType;

        public AccountTypeService(IAccountTypeRepository accountType)
            => this.accountType = accountType;

        public async Task CreateAsync(AccountTypeModel model)
        {
            accountType.Create(AutoMapper.Mapper.Map<AccountType>(model));
            await accountType.SaveAsync();
        }

        public async Task DeleteAsync(AccountTypeModel model)
        {
            this.accountType.Delete(AutoMapper.Mapper.Map<AccountType>(model));
            await accountType.SaveAsync();
        }

        public async Task<IEnumerable<AccountTypeModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<AccountTypeModel>>(await accountType.GetAllAsync());

        public async Task<AccountTypeModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<AccountTypeModel>(await accountType.GetByIDAsync(id));

        public async Task UpdateAsync(AccountTypeModel model)
        {
            accountType.Update(AutoMapper.Mapper.Map<AccountType>(model));
            await accountType.SaveAsync();
        }
    }
}

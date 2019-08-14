using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class UserLevelService : IUserLevelService
    {
        private readonly IUserLevelRepository accountType;

        public UserLevelService(IUserLevelRepository accountType)
            => this.accountType = accountType;

        public async Task CreateAsync(UserLevelModel model)
        {
            accountType.Create(AutoMapper.Mapper.Map<UserLevel>(model));
            await accountType.SaveAsync();
        }

        public async Task DeleteAsync(UserLevelModel model)
        {
            this.accountType.Delete(AutoMapper.Mapper.Map<UserLevel>(model));
            await accountType.SaveAsync();
        }

        public async Task<IEnumerable<UserLevelModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<UserLevelModel>>(await accountType.GetAllAsync());

        public async Task<UserLevelModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<UserLevelModel>(await accountType.GetByIDAsync(id));

        public async Task UpdateAsync(UserLevelModel model)
        {
            accountType.Update(AutoMapper.Mapper.Map<UserLevel>(model));
            await accountType.SaveAsync();
        }
    }
}

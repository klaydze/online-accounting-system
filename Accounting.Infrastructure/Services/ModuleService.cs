using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class ModuleService : IModuleService
    {
        private readonly IModuleRepository accountType;

        public ModuleService(IModuleRepository accountType)
            => this.accountType = accountType;

        public async Task CreateAsync(ModuleModel model)
        {
            accountType.Create(AutoMapper.Mapper.Map<Module>(model));
            await accountType.SaveAsync();
        }

        public async Task DeleteAsync(ModuleModel model)
        {
            this.accountType.Delete(AutoMapper.Mapper.Map<Module>(model));
            await accountType.SaveAsync();
        }

        public async Task<IEnumerable<ModuleModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<ModuleModel>>(await accountType.GetAllAsync());

        public async Task<ModuleModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<ModuleModel>(await accountType.GetByIDAsync(id));

        public async Task UpdateAsync(ModuleModel model)
        {
            accountType.Update(AutoMapper.Mapper.Map<Module>(model));
            await accountType.SaveAsync();
        }
    }
}

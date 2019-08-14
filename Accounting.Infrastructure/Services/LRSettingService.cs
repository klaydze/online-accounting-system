using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class LRSettingService : ILRSettingService
    {
        private readonly ILRSettingRepository lRSetting;

        public LRSettingService(ILRSettingRepository lRSetting)
            => this.lRSetting = lRSetting;

        public async Task CreateAsync(LRSettingModel model)
        {
            lRSetting.Create(AutoMapper.Mapper.Map<LRSetting>(model));
            await lRSetting.SaveAsync();
        }

        public async Task DeleteAsync(LRSettingModel model)
        {
            this.lRSetting.Delete(AutoMapper.Mapper.Map<LRSetting>(model));
            await lRSetting.SaveAsync();
        }

        public async Task<IEnumerable<LRSettingModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<LRSettingModel>>(await lRSetting.GetAllAsync());

        public async Task<LRSettingModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<LRSettingModel>(await lRSetting.GetByIDAsync(id));

        public async Task UpdateAsync(LRSettingModel model)
        {
            lRSetting.Update(AutoMapper.Mapper.Map<LRSetting>(model));
            await lRSetting.SaveAsync();
        }
    }
}

using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class ARSettingService : IARSettingService
    {
        private readonly IARSettingRepository aRSetting;

        public ARSettingService(IARSettingRepository aRSetting)
            => this.aRSetting = aRSetting;

        public async Task CreateAsync(ARSettingModel model)
        {
            aRSetting.Create(AutoMapper.Mapper.Map<ARSetting>(model));
            await aRSetting.SaveAsync();
        }

        public async Task DeleteAsync(ARSettingModel model)
        {
            this.aRSetting.Delete(AutoMapper.Mapper.Map<ARSetting>(model));
            await aRSetting.SaveAsync();
        }

        public async Task<IEnumerable<ARSettingModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<ARSettingModel>>(await aRSetting.GetAllAsync());

        public async Task<ARSettingModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<ARSettingModel>(await aRSetting.GetByIDAsync(id));

        public async Task UpdateAsync(ARSettingModel model)
        {
            aRSetting.Update(AutoMapper.Mapper.Map<ARSetting>(model));
            await aRSetting.SaveAsync();
        }
    }
}

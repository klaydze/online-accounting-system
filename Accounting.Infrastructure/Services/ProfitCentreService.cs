using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class ProfitCentreService : IProfitCentreService
    {
        private readonly IProfitCentreRepository ProfitCentre;

        public ProfitCentreService(IProfitCentreRepository ProfitCentre)
            => this.ProfitCentre = ProfitCentre;

        public async Task CreateAsync(ProfitCentreModel model)
        {
            ProfitCentre.Create(AutoMapper.Mapper.Map<ProfitCentre>(model));
            await ProfitCentre.SaveAsync();
        }

        public async Task DeleteAsync(ProfitCentreModel model)
        {
            this.ProfitCentre.Delete(AutoMapper.Mapper.Map<ProfitCentre>(model));
            await ProfitCentre.SaveAsync();
        }

        public async Task<IEnumerable<ProfitCentreModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<ProfitCentreModel>>(await ProfitCentre.GetAllAsync());

        public async Task<ProfitCentreModel> GetByIDAsync(Guid? id) => AutoMapper.Mapper.Map<ProfitCentreModel>(await ProfitCentre.GetByIDAsync(id));

        public async Task UpdateAsync(ProfitCentreModel model)
        {
            ProfitCentre.Update(AutoMapper.Mapper.Map<ProfitCentre>(model));
            await ProfitCentre.SaveAsync();
        }
    }
}

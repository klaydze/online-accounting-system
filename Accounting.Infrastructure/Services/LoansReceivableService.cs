using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class LoansReceivableService : ILoansReceivableService
    {
        private readonly ILoansReceivableRepository loansReceivable;

        public LoansReceivableService(ILoansReceivableRepository loansReceivable)
            => this.loansReceivable = loansReceivable;

        public async Task CreateAsync(LoansReceivableModel model)
        {
            loansReceivable.Create(AutoMapper.Mapper.Map<LoansReceivable>(model));
            await loansReceivable.SaveAsync();
        }

        public async Task DeleteAsync(LoansReceivableModel model)
        {
            this.loansReceivable.Delete(AutoMapper.Mapper.Map<LoansReceivable>(model));
            await loansReceivable.SaveAsync();
        }

        public async Task<IEnumerable<LoansReceivableModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<LoansReceivableModel>>(await loansReceivable.GetAllAsync());

        public async Task<LoansReceivableModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<LoansReceivableModel>(await loansReceivable.GetByIDAsync(id));

        public async Task UpdateAsync(LoansReceivableModel model)
        {
            loansReceivable.Update(AutoMapper.Mapper.Map<LoansReceivable>(model));
            await loansReceivable.SaveAsync();
        }
    }
}

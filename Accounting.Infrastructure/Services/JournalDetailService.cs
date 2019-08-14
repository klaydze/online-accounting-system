using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class JournalDetailService : IJournalDetailService
    {
        private readonly IJournalDetailRepository journalDetail;

        public JournalDetailService(IJournalDetailRepository journalDetail)
            => this.journalDetail = journalDetail;

        public async Task CreateAsync(JournalDetailModel model)
        {
            journalDetail.Create(AutoMapper.Mapper.Map<JournalDetail>(model));
            await journalDetail.SaveAsync();
        }

        public async Task DeleteAsync(JournalDetailModel model)
        {
            this.journalDetail.Delete(AutoMapper.Mapper.Map<JournalDetail>(model));
            await journalDetail.SaveAsync();
        }

        public async Task<IEnumerable<JournalDetailModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<JournalDetailModel>>(await journalDetail.GetAllAsync());

        public async Task<JournalDetailModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<JournalDetailModel>(await journalDetail.GetByIDAsync(id));

        public async Task UpdateAsync(JournalDetailModel model)
        {
            journalDetail.Update(AutoMapper.Mapper.Map<JournalDetail>(model));
            await journalDetail.SaveAsync();
        }
    }
}

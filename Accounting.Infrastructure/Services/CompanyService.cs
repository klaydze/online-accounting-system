using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository Company;

        public CompanyService(ICompanyRepository Company)
            => this.Company = Company;

        public async Task CreateAsync(CompanyModel model)
        {
            Company.Create(AutoMapper.Mapper.Map<Company>(model));
            await Company.SaveAsync();
        }

        public async Task DeleteAsync(CompanyModel model)
        {
            this.Company.Delete(AutoMapper.Mapper.Map<Company>(model));
            await Company.SaveAsync();
        }

        public async Task<IEnumerable<CompanyModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<CompanyModel>>(await Company.GetAllAsync());

        public async Task<CompanyModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<CompanyModel>(await Company.GetByIDAsync(id));

        public async Task UpdateAsync(CompanyModel model)
        {
            Company.Update(AutoMapper.Mapper.Map<Company>(model));
            await Company.SaveAsync();
        }
    }
}

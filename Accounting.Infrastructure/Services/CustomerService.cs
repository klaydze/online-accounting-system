using Accounting.Domain.Entities;
using Accounting.Domain.Interfaces;
using Accounting.Infrastructure.Interfaces;
using Accounting.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customer;

        public CustomerService(ICustomerRepository customer)
            => this.customer = customer;

        public async Task CreateAsync(CustomerModel model)
        {
            customer.Create(AutoMapper.Mapper.Map<Customer>(model));
            await customer.SaveAsync();
        }

        public async Task DeleteAsync(CustomerModel model)
        {
            this.customer.Delete(AutoMapper.Mapper.Map<Customer>(model));
            await customer.SaveAsync();
        }

        public async Task<IEnumerable<CustomerModel>> GetAllAsync()
            => AutoMapper.Mapper.Map<IEnumerable<CustomerModel>>(await customer.GetAllAsync());

        public async Task<CustomerModel> GetByIDAsync(Guid? id)
            => AutoMapper.Mapper.Map<CustomerModel>(await customer.GetByIDAsync(id));

        public async Task UpdateAsync(CustomerModel model)
        {
            customer.Update(AutoMapper.Mapper.Map<Customer>(model));
            await customer.SaveAsync();
        }
    }
}

using System;
using Customer.API.Contracts;
using Customer.API.Model;

namespace Customer.API.Repositories
{
	public interface ICustomerRepository
	{
        Task<bool> CreateAsync(CustomerModel customer);

        Task<CustomerModel?> GetAsync(Guid id);

        Task<IEnumerable<CustomerModel>> GetAllAsync();

        Task<bool> UpdateAsync(CustomerModel customer);

        Task<bool> DeleteAsync(Guid id);
    }

}


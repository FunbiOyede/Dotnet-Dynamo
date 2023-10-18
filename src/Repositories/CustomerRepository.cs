using System;
using Customer.API.Model;

namespace Customer.API.Repositories
{
	public class CustomerRepository : ICustomerRepository
    {
		public CustomerRepository()
		{
		}

        public Task<bool> CreateAsync(CustomerModel customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CustomerModel?> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(CustomerModel customer)
        {
            throw new NotImplementedException();
        }
    }
}


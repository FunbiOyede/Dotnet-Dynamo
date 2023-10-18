using System;
using Customer.API.Contracts;
using Customer.API.Model;

namespace Customer.API.Services
{
	public class CustomerService : ICustomerService
    {
        private readonly ILogger<CustomerService> _logger;

        public CustomerService(ILogger<CustomerService> logger)
		{
            _logger = logger;
		}

        public Task<bool> CreateCustomer(CustomersDTO customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomer(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomersDTO>> GetAllCustomers(CustomersDTO customer)
        {
            throw new NotImplementedException();
        }

        public Task<CustomersDTO> GetCustomer(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCustomer(CustomersDTO customer)
        {
            throw new NotImplementedException();
        }
    }
}


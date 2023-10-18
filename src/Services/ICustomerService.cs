using System;
using Customer.API.Contracts;
using Customer.API.Model;
namespace Customer.API.Services
{
	public interface ICustomerService
	{

        Task<List<CustomersDTO>> GetAllCustomers(CustomersDTO customer);
        Task<CustomersDTO> GetCustomer(Guid id);
        Task<bool> DeleteCustomer(Guid id);
        Task<bool> UpdateCustomer(CustomersDTO customer);
        Task<bool> CreateCustomer(CustomersDTO customer);
    }
}


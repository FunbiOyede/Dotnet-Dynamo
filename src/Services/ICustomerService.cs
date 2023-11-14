using System;
using Customer.API.Contracts;
using Customer.API.Model;
namespace Customer.API.Services
{
	public interface ICustomerService
	{

        Task<List<CustomersDTO>> GetAllCustomers(CustomersDTO customer);
        Task<ServiceResponse> GetCustomer(Guid id);
        Task<ServiceResponse> DeleteCustomer(Guid id);
        Task<ServiceResponse> UpdateCustomer(Guid id, CustomersDTO customer);
        Task<ServiceResponse> CreateCustomer(CustomersDTO customer);
    }
}


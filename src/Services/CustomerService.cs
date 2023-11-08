using System;
using AutoMapper;
using Customer.API.Contracts;
using Customer.API.Model;
using Customer.API.Repositories;

namespace Customer.API.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ILogger<CustomerService> _logger;
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ILogger<CustomerService> logger, ICustomerRepository customerRepository, IMapper mapper)
        {
            _logger = logger;
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse> CreateCustomer(CustomersDTO customer)
        {
            _logger.LogInformation("Creating User");
            var customerData = _mapper.Map<CustomerModel>(customer);

            var createdUser = await _customerRepository.CreateAsync(customerData);

            if (!createdUser)
            {
                return null;
            }


            var response = new ServiceResponse
            {
                status = createdUser,
                message = "Item created successfully",
                data = customerData
            };

            return response;
        }

        public async Task<ServiceResponse> DeleteCustomer(Guid id)
        {
            var customer = await _customerRepository.DeleteAsync(id);

            if (!customer) return null;

            var response = new ServiceResponse
            {
                status = customer,
                message = "Item deleted successfully",
                data = null
            };

            return response; ;
        }

        public Task<List<CustomersDTO>> GetAllCustomers(CustomersDTO customer)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse> GetCustomer(Guid id)
        {
            var customer = await _customerRepository.GetAsync(id);

            if (customer is null) return null;
            

            var customerData = _mapper.Map<CustomersDTO>(customer);
            var response = new ServiceResponse
            {
                status = true,
                message = string.Empty,
                data = customerData
            };

            return response;
        }


        public async Task<ServiceResponse> UpdateCustomer(CustomersDTO customerDto)
        {
            var customerData = _mapper.Map<CustomerModel>(customerDto);

            var customer = await _customerRepository.UpdateAsync(customerData);

            if (!customer) return null;

            var response = new ServiceResponse
            {
                status = customer,
                message = "updated Customer Successfully",
                data = customerData
            };

            return response;
        }


    }

}



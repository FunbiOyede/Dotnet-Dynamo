using System;
namespace Customer.API.Contracts
{
	
    public record CustomersDTO(string FullName, string Username, string Email, DateTime DateOfBirth);

}


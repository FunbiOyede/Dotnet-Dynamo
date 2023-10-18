using System;
namespace Customer.API.Model
{
	public record CustomerModel(Guid Id, string FullName, string Username, string Email, DateTime DateOfBirth);
}


using System;
namespace Customer.API.Model
{
	

	public record CustomerModel
	{
		public Guid id { get; set; }

		public string pk => id.ToString();

		public string sk => id.ToString();

		public string FullName { get; init; } = default!;

		public string Username { get; init; } = default!;

		public string Email { get; init; } = default!;

		public DateTime DateOfBirth { get; init; }

		public DateTime UpdatedAt { get; set; } 

	}
}


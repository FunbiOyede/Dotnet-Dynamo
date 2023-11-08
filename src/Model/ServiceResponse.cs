using System;
namespace Customer.API.Model
{
	public record ServiceResponse
	{
		public bool status { get; init; }
		public string message { get; init; } = default!;
		public object data { get; init; } = default!;
	}
		
}


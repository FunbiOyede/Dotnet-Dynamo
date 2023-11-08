using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customer.API.Contracts;
using Customer.API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Customer.API.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customer)
        {
            _customerService = customer;
        }
        // GET: api/values
        //[HttpGet]
        //public async Task<IActionResult> GetAllCustomer()
        //{

        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(Guid id)
        {
            var response = await _customerService.GetCustomer(id);

            if (!response.status) return NoContent();

           return Ok(new { Message = response.message, Data = response.data });
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomersDTO customer)
        {
            var response = await _customerService.CreateCustomer(customer);
            if (!response.status) return BadRequest();
            
            return Ok(new { Message = response.message, Data = response.data });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCutomer(int id, [FromBody] CustomersDTO customer)
        {
            var response = await _customerService.UpdateCustomer(customer);
            if (!response.status) return BadRequest();

            return Ok(new { Message = response.message, Data = response.data });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            var response = await _customerService.DeleteCustomer(id);
            if (!response.status) return NoContent();

            return Ok(new { Message = response.message, Data = response.data });
        }
    }
}


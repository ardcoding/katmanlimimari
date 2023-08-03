using BusinessServices.Layer.Interface;
using Microsoft.AspNetCore.Mvc;
using CommerceDb.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomersController : ControllerBase
    {
        private readonly ICustomerBusiness _customerBusiness;

        public CustomersController(ICustomerBusiness customerBusiness)
        {
            _customerBusiness = customerBusiness;
        }
        [HttpGet]
        public async Task<List<Customer>> GetCustomers()
        {
            return await _customerBusiness.GetCustomers();
        }
        [HttpGet("{id}")]
        public async Task<Customer> GetCustomerById(int id)
        {
            return await _customerBusiness.GetCustomerById(id);
        }

        [HttpGet("ByName/{name}")]
        public async Task<Customer> GetCustomerByName(string name)
        {
            return await _customerBusiness.GetCustomerByName(name);
        }
        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customer customer) 
        { 
            _customerBusiness.AddCustomer(customer);
            return Ok(customer);
        }
        [HttpPut("UpdateCustomer")]
        public IActionResult UpdateCustomer([FromBody] Customer customer) {
            _customerBusiness.UpdateCustomer(customer);
            return Ok(customer);
        }

        [HttpDelete("DeleteCustomer/{id}")]
        public async Task DeleteCustomer(int id) { 
           await _customerBusiness.DeleteCustomer(id);
        }
    }
}

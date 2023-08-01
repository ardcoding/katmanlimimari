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
        public List<Customer> GetCustomers()
        {
            return _customerBusiness.GetCustomers();
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
        public void DeleteCustomer(int id) { 
            _customerBusiness.DeleteCustomer(id);
        }
    }
}

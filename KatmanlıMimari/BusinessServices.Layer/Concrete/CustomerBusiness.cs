using BusinessServices.Layer.Interface;
using DataAccess.Layer.Interface;
using CommerceDb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices.Layer.Concrete
{
    public class CustomerBusiness : ICustomerBusiness
    {
        private readonly ICustomerRepository _repository;
        public CustomerBusiness(ICustomerRepository repository) { 
        _repository = repository;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _repository.GetCustomers();
        }
        public async Task<Customer> AddCustomer(Customer customer)
        {
                return await _repository.AddCustomer(customer);
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            return await _repository.UpdateCustomer(customer);
        }

        public async Task DeleteCustomer(int id)
        {
            await _repository.DeleteCustomer(id);
        }
    }
}

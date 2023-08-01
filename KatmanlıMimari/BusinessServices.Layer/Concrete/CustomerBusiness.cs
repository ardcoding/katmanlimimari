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

        public List<Customer> GetCustomers()
        {
            return _repository.GetCustomers();
        }
        public Customer AddCustomer(Customer customer)
        {
            return _repository.AddCustomer(customer);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return _repository.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _repository.DeleteCustomer(id);
        }
    }
}

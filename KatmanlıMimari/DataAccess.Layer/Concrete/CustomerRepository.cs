using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommerceDb.Entities;
using DataAccess.Layer.Interface;

namespace DataAccess.Layer.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CommerceDbContext _dbcontext;

        public CustomerRepository(CommerceDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<Customer> GetCustomers()
        {
            return _dbcontext.Customers.ToList();
        }
        public Customer AddCustomer(Customer customer)
        {
           _dbcontext.Customers.Add(customer);
            _dbcontext.SaveChanges();
            return customer;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            _dbcontext.Customers.Update(customer);
            _dbcontext.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(int id)
        {
            var deletedCustomer = _dbcontext.Customers.Find(id);
            _dbcontext.Customers.Remove(deletedCustomer);
            _dbcontext.SaveChanges();
        }
    }
}

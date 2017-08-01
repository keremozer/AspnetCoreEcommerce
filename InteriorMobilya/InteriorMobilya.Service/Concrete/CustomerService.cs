using InteriorMobilya.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using InteriorMobilya.Model;
using System.Linq.Expressions;
using InteriorMobilya.DataAccess.Abstract;

namespace InteriorMobilya.Service.Concrete
{
    public class CustomerService : ICustomerService
    {
        private ICustomer _customer;
        public CustomerService(ICustomer customer)
        {
            _customer = customer;
        }
        public void Add(Customer customer)
        {
            _customer.Add(customer);
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            return _customer.Get(filter);
        }

        public void Update(Customer customer)
        {
            _customer.Update(customer);
        }
    }
}

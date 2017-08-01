using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InteriorMobilya.Service.Abstract
{
    public interface ICustomerService
    {
        Customer Get(Expression<Func<Customer, bool>> filter);
        void Add(Customer customer);
        void Update(Customer customer);
    }
}

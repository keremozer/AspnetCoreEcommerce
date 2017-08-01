
using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace InteriorMobilya.Service.Abstract
{
    public interface ICustomerAdressService
    {
        void Add(CustomerAdress adress);
        void Update(CustomerAdress adress);
        void Remove(CustomerAdress adress);
        IQueryable<CustomerAdress> GetAll(Expression<Func<CustomerAdress, bool>> filter);
        CustomerAdress Get(Expression<Func<CustomerAdress, bool>> filter);
    }
}

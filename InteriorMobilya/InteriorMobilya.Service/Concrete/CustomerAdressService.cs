using InteriorMobilya.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using InteriorMobilya.Model;
using System.Linq;
using System.Linq.Expressions;
using InteriorMobilya.DataAccess.Abstract;

namespace InteriorMobilya.Service.Concrete
{
    public class CustomerAdressService : ICustomerAdressService
    {
        private readonly ICustomerAdress _customerAdress;
        public CustomerAdressService(ICustomerAdress customerAdress)
        {
            _customerAdress = customerAdress;
        }
        public void Add(CustomerAdress adress)
        {
            _customerAdress.Add(adress);
        }

        public CustomerAdress Get(Expression<Func<CustomerAdress, bool>> filter=null)
        {
            return _customerAdress.Get(filter);
        }

        public IQueryable<CustomerAdress> GetAll(Expression<Func<CustomerAdress, bool>> filter=null)
        {
            return _customerAdress.GetAll(filter);
        }

        public void Remove(CustomerAdress adress)
        {
            _customerAdress.Delete(adress);
        }

        public void Update(CustomerAdress adress)
        {
            _customerAdress.Update(adress);
        }
    }
}

using InteriorMobilya.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using InteriorMobilya.Model;
using System.Linq.Expressions;
using InteriorMobilya.DataAccess.Abstract;
using System.Linq;

namespace InteriorMobilya.Service.Concrete
{
    public class ProductService : IProductService
    {
        private IProduct _product;
        public ProductService(IProduct product)
        {
            _product = product;
        }
        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return filter == null ?
              _product.Get() :
              _product.Get(filter);
        }

        public IQueryable<Product> GetAll()
        {
            return _product.GetAll();
        }
    }
}

using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace InteriorMobilya.Service.Abstract
{
    public interface IProductService
    {
        IQueryable<Product> GetAll();
        Product Get(Expression<Func<Product, bool>> filter);
    }
}

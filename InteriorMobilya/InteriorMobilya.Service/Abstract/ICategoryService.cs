using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace InteriorMobilya.Service.Abstract
{
    public interface ICategoryService
    {
        IQueryable<Category> GetAll();
        Category Get(Expression<Func<Category, bool>> filter=null);

    }
}

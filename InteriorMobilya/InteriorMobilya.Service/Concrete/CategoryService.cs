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
    public class CategoryService : ICategoryService
    {
        private ICategory _category;
        public CategoryService(ICategory category)
        {
            _category = category;
        }
        public Category Get(Expression<Func<Category, bool>> filter =null)
        {
            return filter == null ?
                _category.Get() :
                _category.Get(filter);
        }

        public IQueryable<Category> GetAll()
        {
            return _category.GetAll();
        }
    }
}

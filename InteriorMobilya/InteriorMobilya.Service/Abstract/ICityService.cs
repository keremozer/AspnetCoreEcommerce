using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace InteriorMobilya.Service.Abstract
{
    public interface ICityService
    {
        IQueryable<City> GetAll(Expression<Func<City, bool>> filter = null);
        City Get(Expression<Func<City, bool>> filter = null);
    }
}

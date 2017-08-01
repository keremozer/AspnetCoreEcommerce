using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace InteriorMobilya.Service.Abstract
{
    public interface ICountryService
    {
        IQueryable<Country> GetAll(Expression<Func<Country, bool>> filter = null);
        Country Get(Expression<Func<Country, bool>> filter = null);
    }
}

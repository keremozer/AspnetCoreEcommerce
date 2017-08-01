using InteriorMobilya.DataAccess.Abstract;
using InteriorMobilya.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using InteriorMobilya.Model;
using System.Linq;
using System.Linq.Expressions;

namespace InteriorMobilya.Service.Concrete
{
    public class CountryService :ICountryService
    {
        private readonly ICountry _country;

        public CountryService(ICountry country)
        {
            _country = country;
        }

        public Country Get(Expression<Func<Country, bool>> filter = null)
        {
            return _country.Get(filter);
        }

        public IQueryable<Country> GetAll(Expression<Func<Country, bool>> filter = null)
        {
            return _country.GetAll(filter);
        }
    }
}

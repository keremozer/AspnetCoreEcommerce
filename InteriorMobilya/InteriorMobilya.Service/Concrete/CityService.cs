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
    public class CityService : ICityService
    {
        private readonly ICity _city;

        public CityService(ICity city)
        {
            _city = city;
        }
        public City Get(Expression<Func<City, bool>> filter = null)
        {
            return _city.Get(filter);
        }

        public IQueryable<City> GetAll(Expression<Func<City, bool>> filter = null)
        {
            return _city.GetAll(filter);
        }
    }
}

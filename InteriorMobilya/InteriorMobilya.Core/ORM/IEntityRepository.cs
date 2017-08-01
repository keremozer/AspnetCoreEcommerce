using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace InteriorMobilya.Core.ORM
{
    public interface IEntityRepository<T> where T : class
    {
        //Get 
        T Get(Expression<Func<T, bool>> filter = null);

        //Get All
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null);

        //Add
        void Add(T entity);

        //Delete 
        void Delete(T entity);

        //Update
        void Update(T entity);
    }
}

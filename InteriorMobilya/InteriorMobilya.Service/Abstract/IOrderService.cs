using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace InteriorMobilya.Service.Abstract
{
    public interface IOrderService
    {
        IQueryable<Order> GetAll(Expression<Func<Order, bool>> filter = null);
        Order Get(Expression<Func<Order, bool>> filter=null);

        void Add(Order order);

    }
}

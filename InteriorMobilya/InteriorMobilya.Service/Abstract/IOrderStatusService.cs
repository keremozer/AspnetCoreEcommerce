using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace InteriorMobilya.Service.Abstract
{
    public interface IOrderStatusService
    {
        IQueryable<OrderStatus> GetAll(Expression<Func<OrderStatus, bool>> filter = null);
        OrderStatus Get(Expression<Func<OrderStatus, bool>> filter = null);
    }
}

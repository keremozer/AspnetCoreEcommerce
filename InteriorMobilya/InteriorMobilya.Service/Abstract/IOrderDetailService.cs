using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace InteriorMobilya.Service.Abstract
{
    public interface IOrderDetailService
    {
        IQueryable<OrderDetail> GetAll(Expression<Func<OrderDetail, bool>> filter = null);
        OrderDetail Get(Expression<Func<OrderDetail, bool>> filter = null);

        void Add(OrderDetail orderdetail);
    }
}

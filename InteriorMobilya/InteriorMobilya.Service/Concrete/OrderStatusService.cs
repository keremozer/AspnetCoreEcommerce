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

    public class OrderStatusService : IOrderStatusService
    {
        private readonly IOrderStatus _orderStatus;

        public OrderStatusService(IOrderStatus orderStatus)
        {
            _orderStatus = orderStatus;
        }
        public OrderStatus Get(Expression<Func<OrderStatus, bool>> filter = null)
        {
            return _orderStatus.Get(filter);
        }

        public IQueryable<OrderStatus> GetAll(Expression<Func<OrderStatus, bool>> filter = null)
        {
            return _orderStatus.GetAll(filter);
        }
    }
}

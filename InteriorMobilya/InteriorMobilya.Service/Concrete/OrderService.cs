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
    public class OrderService : IOrderService
    {
        private readonly IOrder _order;

        public OrderService(IOrder order)
        {
            _order = order;
        }
        public void Add(Order order)
        {
            _order.Add(order);
        }

        public Order Get(Expression<Func<Order, bool>> filter = null)
        {
            return _order.Get(filter);
        }

        public IQueryable<Order> GetAll(Expression<Func<Order, bool>> filter = null)
        {
            return _order.GetAll(filter);
        }
    }
}

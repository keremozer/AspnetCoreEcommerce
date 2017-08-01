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
    public class OrderDetailService : IOrderDetailService
    {
        public IOrderDetail _orderDetail { get; private set; }
        public OrderDetailService(IOrderDetail orderDetail)
        {
            _orderDetail = orderDetail;
        }

        

        public void Add(OrderDetail orderdetail)
        {
            _orderDetail.Add(orderdetail);
        }

        public OrderDetail Get(Expression<Func<OrderDetail, bool>> filter = null)
        {
            return _orderDetail.Get(filter);
        }

        public IQueryable<OrderDetail> GetAll(Expression<Func<OrderDetail, bool>> filter = null)
        {
            return _orderDetail.GetAll(filter);
        }
    }
}

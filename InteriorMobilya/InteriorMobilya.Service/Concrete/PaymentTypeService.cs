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
    public class PaymentTypeService : IPaymentTypeService
    {
        private  readonly IPaymentType _paymentType;

        public PaymentTypeService(IPaymentType paymentType)
        {
            _paymentType = paymentType;
        }
        public PaymentType Get(Expression<Func<PaymentType, bool>> filter = null)
        {
            return _paymentType.Get(filter);
        }

        public IQueryable<PaymentType> GetAll(Expression<Func<PaymentType, bool>> filter = null)
        {
            return _paymentType.GetAll(filter);
        }
    }
}

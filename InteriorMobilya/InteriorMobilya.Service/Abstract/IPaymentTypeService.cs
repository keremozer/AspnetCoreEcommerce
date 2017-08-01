using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace InteriorMobilya.Service.Abstract
{
    public interface IPaymentTypeService
    {
        IQueryable<PaymentType> GetAll(Expression<Func<PaymentType, bool>> filter = null);
        PaymentType Get(Expression<Func<PaymentType, bool>> filter = null);
    }
}

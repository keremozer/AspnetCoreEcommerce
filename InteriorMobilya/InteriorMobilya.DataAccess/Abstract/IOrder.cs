using InteriorMobilya.Core.ORM;
using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteriorMobilya.DataAccess.Abstract
{
    public interface IOrder : IEntityRepository<Order>
    {
    }
}

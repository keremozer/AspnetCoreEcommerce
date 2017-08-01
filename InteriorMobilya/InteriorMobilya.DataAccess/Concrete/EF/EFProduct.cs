using InteriorMobilya.DataAccess.Abstract;
using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using InteriorMobilya.Core.ORM.EF;

namespace InteriorMobilya.DataAccess.Concrete.EF
{
    public class EFProduct : EFBaseRepository<DatabaseContext, Product>, IProduct
    {
         
    }
}

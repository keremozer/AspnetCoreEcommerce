using InteriorMobilya.Core.ORM.EF;
using InteriorMobilya.DataAccess.Abstract;
using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteriorMobilya.DataAccess.Concrete.EF
{
    public class EFCity : EFBaseRepository<DatabaseContext, City>, ICity
    {
    }
}

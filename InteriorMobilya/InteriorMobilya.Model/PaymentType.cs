using InteriorMobilya.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteriorMobilya.Model
{
    public class PaymentType : IEntity
    {
        //Pk
        public int PaymentTypeID { get; set; }
        //Prop
        public string Type { get; set; }

        public bool IsActive { get; set; }

        //NaviProp
        public virtual ICollection<Order> Orders { get; set; }

    }
}

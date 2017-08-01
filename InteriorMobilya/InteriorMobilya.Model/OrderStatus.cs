using InteriorMobilya.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteriorMobilya.Model
{
    public class OrderStatus : IEntity
    {
        //Pk
        public int OrderStatusID { get; set; }
        //Prop
        public string Status { get; set; }
        public bool IsActive { get; set; }

        //NaviProp
        public virtual ICollection<Order> Orders { get; set; }
    }
}

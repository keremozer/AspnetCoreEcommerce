using InteriorMobilya.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteriorMobilya.Model
{
    public class Product : IEntity
    {
        //PK
        public int ProductID { get; set; }
        //FK
        public int CategoryID { get; set; }
       
        //Prop
        public string ProductName { get; set; }
        public string ImagePath { get; set; }

        public string ProductDescription { get; set; }
        public bool IsActive { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

        //NProp

        public virtual Category Category { get; set; }
        
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }


    }
}

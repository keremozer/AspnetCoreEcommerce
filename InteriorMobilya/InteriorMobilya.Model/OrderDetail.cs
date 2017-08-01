using InteriorMobilya.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InteriorMobilya.Model
{
    [Table("OrderDetails")]
    public class OrderDetail : IEntity
    {
        //PK -composite
        //[Column(Order = 0),Key]
        public int OrderID { get; set; }
     
        //[Column(Order = 1), Key]
        public int ProductID { get; set; }
        //Prop
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
       

    }
}

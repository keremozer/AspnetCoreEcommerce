using InteriorMobilya.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InteriorMobilya.Model
{
    [Table("Orders")]
    public class Order : IEntity
    {
         
        //PK
        public int OrderID { get; set; }
        //FK
        public int CustomerID { get; set; }
        public int CustomerAdressID { get; set; }
        public int OrderStatusID { get; set; }
        public int PaymentTypeID { get; set; }
        //Prop
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }

        //Naviprop
        public virtual PaymentType PaymentType { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
         
        public virtual CustomerAdress CustomerAdress { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}

using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.Models
{
    public class OrderDetailViewModel
    {
        public Order Order { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentType PaymentType { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
        public CustomerAdress CustomerAdress { get; set; }
    }
}

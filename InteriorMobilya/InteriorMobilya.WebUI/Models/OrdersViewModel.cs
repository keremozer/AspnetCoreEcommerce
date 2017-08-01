using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.Models
{
    public class OrdersViewModel
    {
        public ICollection<OrderStatus> OrderStatus { get; set; }
        
        public ICollection<Order> Orders { get; set; }
      
    }
}

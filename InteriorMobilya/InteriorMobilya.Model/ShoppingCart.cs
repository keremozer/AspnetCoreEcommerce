using InteriorMobilya.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InteriorMobilya.Model
{
    public class ShoppingCart 
    {
        public ICollection<CartItem> CartItems { get; set; }
       
        public ShoppingCart()
        {
            CartItems = new List<CartItem>();
        }

        public decimal Total
        {
            get
            {
                return CartItems.Sum(c => c.Quantity * c.Product.UnitPrice);    
            }
        }

    }
}

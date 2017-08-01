using InteriorMobilya.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using InteriorMobilya.Model;
using System.Linq;

namespace InteriorMobilya.Service.Concrete
{
    public class ShoppingCartService : IShoppingCartService
    {
        public void AddToCart(ShoppingCart cart, Product product)
        {
            CartItem item = cart.CartItems.FirstOrDefault(x => x.Product.ProductID == product.ProductID);
            if (item != null)
                item.Quantity++;
            else
                cart.CartItems.Add(new CartItem { Quantity = 1, Product = product });
        }

        public void RemoveToCart(ShoppingCart cart, Product product)
        {
            cart.CartItems.Remove(cart.CartItems.FirstOrDefault(x => x.Product.ProductID == product.ProductID));
        }

        public ICollection<CartItem> CartList(ShoppingCart cart)
        {
            return cart.CartItems;
        }

        public void UpdateToCart(ShoppingCart cart, Product product, int quantity)
        {
            cart.CartItems.Where(x => x.Product.ProductID == product.ProductID).FirstOrDefault().Quantity = quantity;

        }
    }
}

using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InteriorMobilya.Service.Abstract
{
    public interface IShoppingCartService
    {
        void AddToCart(ShoppingCart cart, Product product);
        void RemoveToCart(ShoppingCart cart, Product product);
        void UpdateToCart(ShoppingCart cart, Product product, int quantity);
        ICollection<CartItem> CartList(ShoppingCart cart);
    }
}

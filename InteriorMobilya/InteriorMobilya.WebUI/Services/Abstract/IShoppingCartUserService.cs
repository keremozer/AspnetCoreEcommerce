using InteriorMobilya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.Services.Abstract
{
    public interface IShoppingCartUserService
    {
        ShoppingCart GetCart();
        void SetCart(ShoppingCart cart);
    }
}

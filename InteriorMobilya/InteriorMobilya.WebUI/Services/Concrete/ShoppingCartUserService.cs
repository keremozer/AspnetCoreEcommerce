using InteriorMobilya.WebUI.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InteriorMobilya.Model;
using Microsoft.AspNetCore.Http;
using InteriorMobilya.WebUI.Extension;

namespace InteriorMobilya.WebUI.Services.Concrete
{
    public class ShoppingCartUserService : IShoppingCartUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ShoppingCartUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public ShoppingCart GetCart()
        {
            ShoppingCart getCart = _httpContextAccessor.HttpContext.Session.GetObject<ShoppingCart>("Cart");
            if (getCart == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("Cart", new ShoppingCart());
                getCart = _httpContextAccessor.HttpContext.Session.GetObject<ShoppingCart>("Cart");
            }
            return getCart;
        }

        public void SetCart(ShoppingCart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("Cart", cart);
        }
    }
}

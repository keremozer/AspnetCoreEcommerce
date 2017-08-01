using InteriorMobilya.WebUI.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent
    {
        private readonly IShoppingCartUserService _shoppingCartUserService;
        public ShoppingCartViewComponent(IShoppingCartUserService shoppingCartUserService)
        {
            _shoppingCartUserService = shoppingCartUserService;
        }
        public IViewComponentResult Invoke()
        {
             
            return View(_shoppingCartUserService.GetCart());
        }
    }
}

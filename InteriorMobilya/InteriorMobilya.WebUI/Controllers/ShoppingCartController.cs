using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InteriorMobilya.DataAccess.Abstract;
using InteriorMobilya.Service.Abstract;
using InteriorMobilya.WebUI.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using InteriorMobilya.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using InteriorMobilya.WebUI.Entities;

namespace InteriorMobilya.WebUI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductService _productService;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IShoppingCartUserService _shoppingCartUserService;

        private readonly ICustomerAdressService _customerAdressService;
        private readonly ICustomerService _customerService;
        private readonly UserManager<CustomIdentityUser> _userManager;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;

        public ShoppingCartController(IProductService productService,
            IShoppingCartService shoppingCartService,
            IShoppingCartUserService shoppingCartUserService,
            ICustomerAdressService customerAdressService,
            ICustomerService customerService, 
            UserManager<CustomIdentityUser> userManager,
            IOrderService orderService,
            IOrderDetailService orderDetailService)
        {
            _productService = productService;
            _shoppingCartService = shoppingCartService;
            _shoppingCartUserService = shoppingCartUserService;

            _customerAdressService = customerAdressService;
            _customerService = customerService;
            _userManager = userManager;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
        }
        public IActionResult Index()
        {
            return View();
        }
      
        [Authorize]
        [Route("sepetim")]
        public IActionResult CartList()
        {
            return View(_shoppingCartUserService.GetCart());
        }

        [Authorize]
        [Route("odeme")]
        public IActionResult Payment()
        {
            if (_shoppingCartUserService.GetCart().CartItems.Count<1)
                return Redirect("/sepetim");
            var customerID = _customerService.Get(x => x.UserID == _userManager.GetUserAsync(HttpContext.User).Result.Id).CustomerID;
            PaymentViewModel model = new PaymentViewModel
            {
                CustomerAdresses = _customerAdressService.GetAll(x=>x.IsActive==true && x.CustomerID == customerID ).ToList(),
                ShoppingCart = _shoppingCartUserService.GetCart()

            };
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public JsonResult Complete(int id)
        {
            bool ok = false;
            var customerAdresss = _customerAdressService.Get(x => x.CustomerAdressID == id);
            if (customerAdresss != null)
            {
                _orderService.Add(new Model.Order
                {
                    CustomerAdressID = id,
                    OrderDate = DateTime.Now,
                    ShippedDate = DateTime.Now.AddDays(2),
                    RequiredDate = DateTime.Now.AddDays(2),
                    OrderStatusID = 1,
                    PaymentTypeID = 1

                });
                var order =_orderService.GetAll().LastOrDefault();
                foreach (var item in _shoppingCartUserService.GetCart().CartItems)
                {
                    _orderDetailService.Add(new Model.OrderDetail
                    {
                        OrderID = order.OrderID,
                        ProductID = item.Product.ProductID,
                        Quantity = item.Quantity,
                        UnitPrice = item.Product.UnitPrice
                    });
                }
                //sesion sepet boþalt;
                HttpContext.Session.Remove("Cart");
                ok = true;

            }
            return Json(new { ok = ok ,go ="/siparislerim"}); 
        }


        [HttpPost]
        public JsonResult AddToCart(int id)
        {
            bool result = true;
            int count = 0;
            var product = _productService.Get(x => x.ProductID == id);
            if (product == null)
                result = false;
            else
            {
                var cart = _shoppingCartUserService.GetCart();
                _shoppingCartService.AddToCart(cart, product);
                _shoppingCartUserService.SetCart(cart);

            }
            count = _shoppingCartUserService.GetCart().CartItems.Sum(x => x.Quantity);
            return Json(new { ok = result, count = count });
        }

        [HttpPost]
        public JsonResult UpdateToCart(int id ,int quantity)
        {
            bool result = true;
            int count = 0;
            var product = _productService.Get(x => x.ProductID == id);
            if (product == null)
                result = false;
            else
            {
                var cart = _shoppingCartUserService.GetCart();
                _shoppingCartService.UpdateToCart(cart, product, quantity);
                _shoppingCartUserService.SetCart(cart);
            }
            count = _shoppingCartUserService.GetCart().CartItems.Sum(x => x.Quantity);
            return Json(new { ok = result, count = count });


        }

        [HttpPost]
        public JsonResult RemoveToCart(int id)
        {
            bool result = true;
            int count = 0;
            var product = _productService.Get(x => x.ProductID == id);
            if (product == null)
                result = false;
            else
            {
                var cart = _shoppingCartUserService.GetCart();
                _shoppingCartService.RemoveToCart(cart, product);
                _shoppingCartUserService.SetCart(cart);

            }
            count = _shoppingCartUserService.GetCart().CartItems.Sum(x => x.Quantity);
            return Json(new { ok = result, count = count });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InteriorMobilya.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using InteriorMobilya.WebUI.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using InteriorMobilya.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc.Rendering;
using InteriorMobilya.Service.Abstract;
using InteriorMobilya.Model;

namespace InteriorMobilya.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<CustomIdentityUser> _userManager;
        private readonly RoleManager<CustomIdentityRole> _roleManager;
        private readonly SignInManager<CustomIdentityUser> _signInManager;
        private readonly ICustomerService _customerService;
        private readonly ICustomer _customer;
        private readonly ICityService _cityService;
        private readonly ICountryService _countryService;
        private readonly ICustomerAdressService _customerAdressService;
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IProductService _productService;
        private readonly IOrderStatusService _orderStatusService;
        private readonly IPaymentTypeService _paymentTypeService;

        public AccountController(UserManager<CustomIdentityUser> userManager,
            RoleManager<CustomIdentityRole> roleManager,
            SignInManager<CustomIdentityUser> signManager,
            ICustomer customer, ICityService city, ICountryService coutry,
            ICustomerAdressService customerAdressService ,
            ICustomerService customerService,
            IOrderService orderService,
            IOrderDetailService orderDetailService,
            IProductService productService,
            IPaymentTypeService paymentTypeService,
            IOrderStatusService orderStatusService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signManager;
            _customer = customer;
            _cityService = city;
            _countryService = coutry;
            _customerAdressService = customerAdressService;
            _customerService = customerService;
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _productService = productService;
            _orderStatusService = orderStatusService;
            _paymentTypeService = paymentTypeService;
        }
        
        
        [Route("giris")]
        public IActionResult Giris()
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                return View();
            }
            string returnUrl = Request.Headers["Referer"].ToString();
            return Redirect(returnUrl);
           
            
        }
        [Route("giris")]
        [HttpPost,AllowAnonymous]
        public  IActionResult  Giris(LoginViewModel account ,string returnurl ="/")
        {
             
            if (ModelState.IsValid)
            {
                var user =  _userManager.FindByEmailAsync(account.Email).Result;
                var result = _signInManager.PasswordSignInAsync(user.UserName, account.Password,false, lockoutOnFailure:false).Result;
                if (result.Succeeded)
                {
                    return Redirect(returnurl);
                }
                ModelState.AddModelError("", "Kullanýcý adýnýz ya da þifreniz hatalý!");
            }
            return View(account);
        }

        [Route("uyeol")]
        public IActionResult UyeOl()
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                return View();
            }
            string returnUrl = Request.Headers["Referer"].ToString();
            return Redirect(returnUrl);
        }
        [Route("uyeol")]
        [HttpPost]
        public IActionResult UyeOl(RegisterViewModel account)
        {
            if (ModelState.IsValid)
            {
                CustomIdentityUser user = new CustomIdentityUser
                {
                    Email = account.Email,
                    UserName = account.UserName
                };
                var result = _userManager.CreateAsync(user, account.Password).Result;
                if (result.Succeeded)
                {
                    
                    if (!_roleManager.RoleExistsAsync("User").Result)
                    {
                        CustomIdentityRole role = new CustomIdentityRole
                        {
                            Name = "User"
                        };

                        IdentityResult roleResult = _roleManager.CreateAsync(role).Result;

                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "Ýþlem sýrasýnda bir hata oluþtu!");
                            return View(account);
                        }
                    }
                    Guid UserID =  _userManager.FindByEmailAsync(account.Email).Result.Id;
                    _customer.Add(new Model.Customer
                    {
                        CreatedDate = DateTime.Now,
                        UserID = UserID,
                        IsActive = true
                    });

                    _userManager.AddToRoleAsync(user, "User").Wait();
                    return Redirect("/giris");
                }
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var modelError in modelState.Errors)
                    {
                        ModelState.AddModelError("",modelError.ErrorMessage);
                    }
                }
                
               
            }
            return View(account);
        }
        [Route("cikis")]
        public IActionResult Cikis()
        {
            _signInManager.SignOutAsync().Wait();
            return Redirect("/giris");
        }

        [Authorize]
        [Route("hesabim")]
        public IActionResult Hesabim()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            var customer = _customer.Get(x=>x.UserID == user.Id);
            List<SelectListItem> gender = new List<SelectListItem>();
            gender.Add(new SelectListItem
            {
                Text = "Kadýn",
                Value = "true",
                Selected = customer.Gender == true ? true : false
            });
            gender.Add(new SelectListItem
            {
                Text = "Erkek",
                Value = "false",
                Selected = customer.Gender == true ? true : false
            });
            gender.Insert(0, new SelectListItem {  Text="--Seçiniz--",Value =null});
            ViewBag.Gender = gender;
            AccountDetailViewModel model = new AccountDetailViewModel
            {
                BirthDate = customer.BirthDate,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Phone = customer.Phone,
                Gender = customer.Gender ,
                UserName = user.UserName
            };
            return View(model);

        }

        [Route("hesabim")]
        [HttpPost]
        public IActionResult Hesabim(AccountDetailViewModel account)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserAsync(HttpContext.User).Result;
           
                _customer.Update(new Model.Customer
                {
                    CustomerID= _customer.Get(x => x.UserID == user.Id).CustomerID,
                    BirthDate = Convert.ToDateTime(account.BirthDate),
                    FirstName = account.FirstName,
                    Gender = account.Gender!= null ? account.Gender : null,
                    LastName = account.LastName,
                    Phone = account.Phone,
                    UserID = user.Id
                });
                user.UserName = account.UserName;
                
            
                var result =_userManager.UpdateAsync(user).Result;   
            }
            List<SelectListItem> gender = new List<SelectListItem>();
            gender.Add(new SelectListItem
            {
                Text = "Kadýn",
                Value = "true",
            });
            gender.Add(new SelectListItem
            {
                Text = "Erkek",
                Value = "false",
            });
            gender.Insert(0, new SelectListItem { Text = "--Seçiniz--", Value = null });
            ViewBag.Gender = gender;
            return View(account);
        }

        [Authorize]
        [Route("siparislerim")]
        public IActionResult Orders()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;

            var customer = _customerService.Get(x => x.UserID == user.Id);
            var userOrder = _orderService.Get(x => x.CustomerID == customer.CustomerID);
            if (userOrder == null)
                return Redirect("/hesabim");
            var orderStatus = _orderStatusService.GetAll(x => x.OrderStatusID == userOrder.OrderStatusID);
            OrdersViewModel model = new OrdersViewModel{
               
                Orders = _orderService.GetAll(x=>x.CustomerID == userOrder.CustomerID).ToList(),
                OrderStatus = orderStatus.ToList(),
            };
            return View(model);
        }
        [Authorize]
        [Route("siparis/{id:int?}")]
        public IActionResult OrderDetails(int? id)
        {
            if (id == null)
                return Redirect("/siparislerim");
            var customer = _customerService.Get(x => x.UserID == _userManager.GetUserAsync(HttpContext.User).Result.Id);
            var order = _orderService.Get(x => x.OrderID == id && x.CustomerID == customer.CustomerID);
            if (order == null)
                return Redirect("/siparislerim");
            List<Product> products = new List<Product>();
            foreach (var item in _orderDetailService.GetAll(x=>x.OrderID == id).ToList())
            {
                products.Add(_productService.Get(x => x.ProductID == item.ProductID));
            }
            var orderStatus = _orderStatusService.Get(x => x.OrderStatusID == order.OrderStatusID);
            OrderDetailViewModel model = new OrderDetailViewModel
            {
                OrderDetail = _orderDetailService.GetAll(x => x.OrderID == id).ToList(),
                Order = order,
                CustomerAdress = _customerAdressService.Get(x=>x.CustomerAdressID == order.CustomerAdressID),
                Products = products,
                OrderStatus = orderStatus
            };
            return View(model);
        }
        [Authorize]
        [Route("adres-ekle")]
        public IActionResult AdressAdd(string returnurl)
        {
            ViewData["returnurl"] = returnurl;
            List<SelectListItem> CountryList = new List<SelectListItem>();
            foreach (var item in _countryService.GetAll())
            {
                CountryList.Add(new SelectListItem { Text = item.CountryName, Value = item.CountryID.ToString() });
            }
            CountryList.Insert(0, new SelectListItem { Text = "--Seçiniz--", Value = null });
            ViewBag.Country = CountryList;
            return View();
        }

        [HttpPost]
        [Route("adres-ekle")]
        public IActionResult AdressAdd(AccountAdressViewModel adres, string returnurl)
        {
            ViewData["returnurl"] = returnurl;
            List<SelectListItem> CountryList = new List<SelectListItem>();
            foreach (var item in _countryService.GetAll())
            {
                CountryList.Add(new SelectListItem { Text = item.CountryName, Value = item.CountryID.ToString() });
            }
            CountryList.Insert(0, new SelectListItem { Text = "--Seçiniz--", Value = null });
            ViewBag.Country = CountryList;
            if (ModelState.IsValid)
            {
                _customerAdressService.Add(
                    new Model.CustomerAdress
                    {
                        AdressDescription = adres.AdressDescription,
                        AdressTitle = adres.AdressTitle,
                        CityID = Convert.ToInt32(adres.CityID),
                        CreatedDate= DateTime.Now,
                        CustomerID = _customer.Get(x=>x.UserID == _userManager.GetUserAsync(HttpContext.User).Result.Id).CustomerID,
                        IsActive = true,
                        Name = adres.Name,
                        Phone = adres.Phone

                    });

                return returnurl == null ? Redirect("/adreslerim") : (Redirect(returnurl));
            }
            return View(adres);
            
            
        }

        public JsonResult GetCity(int id)
        {
            bool ok = false;
            List<SelectListItem> CityList = new List<SelectListItem>();
            if (_cityService.GetAll(x=>x.CountryID == id).Count()>0)
            {
                foreach (var item in _cityService.GetAll(x => x.CountryID == id))
                {
                    CityList.Add(new SelectListItem { Text = item.CityName, Value = item.CityID.ToString() });
                }
                 ok = true;
            }
            return Json(new { ok = ok, list = CityList });
            
        }

        public JsonResult RemoveAdress(int id)
        {
            bool ok = false;
            var customerAdress = _customerAdressService.Get(x => x.CustomerAdressID == id);
            if (customerAdress != null)
            {
                _customerAdressService.Remove(customerAdress);
                ok = true;
            }
            
           
            return Json(new { ok = ok });

        }
        [Authorize]
        [Route("adreslerim")]
        public IActionResult Adresses()
        {
            
            var customerID = _customerService.Get(x => x.UserID == _userManager.GetUserAsync(HttpContext.User).Result.Id).CustomerID;
            return View(_customerAdressService.GetAll(x => x.IsActive == true && x.CustomerID == customerID).ToList());
        }

        [Authorize]
        [Route("adresim/{id:int?}")]
        public IActionResult AdressEdit(int? id ,string returnurl)
        {
            ViewData["returnurl"] = returnurl;
            if (id == null)
                return Redirect("/adreslerim");
            var customer = _customerService.Get(x => x.UserID == _userManager.GetUserAsync(HttpContext.User).Result.Id);
            var customerAdress = _customerAdressService.Get(x=>x.CustomerAdressID == id && customer.CustomerID==x.CustomerID);
            if (customerAdress == null)
                return Redirect("/adreslerim");
            var city = _cityService.Get(x => x.CityID == customerAdress.CityID);
            List<SelectListItem> CountryList = new List<SelectListItem>();
            foreach (var item in _countryService.GetAll())
            {
                CountryList.Add(new SelectListItem
                {
                    Text = item.CountryName,
                    Value = item.CountryID.ToString(),
                    Selected = (city.CountryID == item.CountryID ? true : false)
                });
            }
            CountryList.Insert(0, new SelectListItem { Text = "--Seçiniz--", Value = null });

          
            List<SelectListItem> CityList = new List<SelectListItem>();
            foreach (var item in _cityService.GetAll(x=>x.CountryID == city.CountryID))
            {
                CityList.Add(new SelectListItem
                {
                    Text = item.CityName,
                    Value = item.CityID.ToString(),
                    Selected = item.CityID == customerAdress.CityID ? true : false
                });
            }
            ViewBag.CityList = CityList;
            ViewBag.Country = CountryList;

            AccountAdressViewModel model = new AccountAdressViewModel
            {
                AdressDescription = customerAdress.AdressDescription,
                AdressTitle = customerAdress.AdressTitle,
                CityID = customerAdress.CityID,
                Name = customerAdress.Name,
                Phone = customerAdress.Phone
            };
            return View(model);
        }
        [HttpPost]
        [Route("adresim/{id}")]
        public IActionResult AdressEdit(AccountAdressViewModel adres,int id, string returnurl)
        {
            ViewData["returnurl"] = returnurl;
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            var customer = _customer.Get(x => x.UserID == user.Id);
            var customerAdress = _customerAdressService.Get(x => x.CustomerAdressID == id);
            var city = _cityService.Get(x => x.CityID == customerAdress.CityID);
            if (customerAdress == null)
                return Redirect("/adreslerim");
            if (ModelState.IsValid)
            {
                _customerAdressService.Update(new Model.CustomerAdress
                {
                    AdressDescription = adres.AdressDescription,
                    AdressTitle = adres.AdressTitle,
                    CityID = Convert.ToInt32(adres.CityID),
                    Name = adres.Name,
                    Phone = adres.Phone,
                    CustomerAdressID= id,
                    CustomerID = customer.CustomerID,
                    CreatedDate= DateTime.Now,
                    IsActive = true
                });
                if (!string.IsNullOrEmpty(returnurl))
                    return Redirect(returnurl);
                return Redirect("/adreslerim");
            }
            return Redirect("/adresim/" + id);
            //List<SelectListItem> CountryList = new List<SelectListItem>();
            //foreach (var item in _countryService.GetAll())
            //{
            //    CountryList.Add(new SelectListItem
            //    {
            //        Text = item.CountryName,
            //        Value = item.CountryID.ToString(),
            //        Selected = (city.CountryID == item.CountryID ? true : false)
            //    });
            //}
            //CountryList.Insert(0, new SelectListItem { Text = "--Seçiniz--", Value = null });


            //List<SelectListItem> CityList = new List<SelectListItem>();
            //foreach (var item in _cityService.GetAll(x => x.CountryID == city.CountryID))
            //{
            //    CityList.Add(new SelectListItem
            //    {
            //        Text = item.CityName,
            //        Value = item.CityID.ToString(),
            //        Selected = item.CityID == customerAdress.CityID ? true : false
            //    });
            //}
            //ViewBag.CityList = CityList;
            //ViewBag.Country = CountryList;

            //AccountAdressViewModel model = new AccountAdressViewModel
            //{
            //    AdressDescription = customerAdress.AdressDescription,
            //    AdressTitle = customerAdress.AdressTitle,
            //    CityID = customerAdress.CityID,
            //    Name = customerAdress.Name,
            //    Phone = customerAdress.Phone
               
            //};
            //return View(model);
        }
    }
}
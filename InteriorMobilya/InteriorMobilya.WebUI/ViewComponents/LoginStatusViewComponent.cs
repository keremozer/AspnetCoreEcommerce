using InteriorMobilya.WebUI.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.ViewComponents
{
    public class LoginStatusViewComponent : ViewComponent
    {
        private readonly UserManager<CustomIdentityUser> _userManager;
        private readonly SignInManager<CustomIdentityUser> _signInManager;
        public LoginStatusViewComponent(UserManager<CustomIdentityUser> userManager, SignInManager<CustomIdentityUser> signManager)
        {
            _userManager = userManager;
            _signInManager = signManager;
        }

        public IViewComponentResult Invoke()
        {
            if (_signInManager.IsSignedIn(HttpContext.User))
            {
                var user =   _userManager.GetUserAsync(HttpContext.User).Result;
                return View("Login", user);

            }
            return View();
        }
    }
}

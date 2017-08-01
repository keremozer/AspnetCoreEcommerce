using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InteriorMobilya.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("urunler/{page:int?}")]
        public IActionResult Index(int? page)
        {
            ViewData["page"] = page;
            return View();
        }
        
        
    }
}

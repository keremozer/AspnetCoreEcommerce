using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InteriorMobilya.DataAccess.Abstract;
using InteriorMobilya.WebUI.Extension;
using InteriorMobilya.Model;

namespace InteriorMobilya.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICategory _category;
        private readonly IProduct _product;
        public ProductController(IProduct product, ICategory category)
        {
            _product = product;
            _category = category;
        }
        const int pageSize = 6;
        [Route("{kategoriAd}/{page:int?}")]
        public IActionResult CategoryProduct(string kategoriAd,int? page)
        {
            if (string.IsNullOrEmpty(kategoriAd))
                Redirect("/");
            var cat = _category.Get(x => x.CategoryName.ToSeoUrl() == kategoriAd);
            if (cat != null)
            {
                ViewBag.CategoryName = cat.CategoryName;
                ViewData["KategoriSeo"] = cat.CategoryName.ToSeoUrl();
                var products = _product.GetAll(x => x.CategoryID == cat.CategoryID).ToList();
                if (products.Count>0)
                {
                    var productPage = new Paging<Product>(products, page ?? 0, pageSize);
                    return View(productPage);
                }
                return View();
            }
            return View("/");
        }
    }
}
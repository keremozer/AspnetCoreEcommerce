using InteriorMobilya.DataAccess.Abstract;
using InteriorMobilya.Model;
using InteriorMobilya.WebUI.Extension;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {
        private readonly IProduct _product;
        const int pageSize = 6;
        public ProductsViewComponent(IProduct product)
        {
            _product = product;
        }
      
        public IViewComponentResult Invoke(int? page)
        {

            var products = _product.GetAll().ToList();
            var productPage = new Paging<Product>(products, page ?? 0, pageSize);
            return View(productPage);
            
        }

    }
}

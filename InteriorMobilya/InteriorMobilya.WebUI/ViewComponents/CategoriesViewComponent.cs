using InteriorMobilya.DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ICategory _category;
        public CategoriesViewComponent(ICategory category)
        {
            _category = category;
        }

        public IViewComponentResult Invoke(int? page)
        {
            return View(_category.GetAll(x=>x.Products.Count>0).ToList());
        }
    }
}

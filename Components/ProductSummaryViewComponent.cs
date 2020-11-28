using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Components
{
    public class ProductSummaryViewComponent : ViewComponent
    {
        private Product product;
        public ProductSummaryViewComponent(Product cartService)
        {
            product = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(product);
        }
    }
}

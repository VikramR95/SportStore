using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportsStore.Models;

namespace SportsStore.Pages
{
    public class ProductInfoModel : PageModel
    {
        private IStoreRepository repository;
        public ProductInfoModel(IStoreRepository repo, Productdisplay cartService)
        {
            repository = repo;
            ProductInfo = cartService;
        }
        public Productdisplay ProductInfo { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            
        }


        public IActionResult OnPost(long productId, string returnUrl)
        {
            Product product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            //ProductInfo.AddItem(product, 1);
            if(product != null)
            {
                ProductInfo.Clear();
                ProductInfo.AddItem(product, 1);

            }

            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long productId, string returnUrl)
        {
            ProductInfo.RemoveLine(ProductInfo.Line.First(cl =>
            cl.Product.ProductID == productId).Product);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

       
    }
}


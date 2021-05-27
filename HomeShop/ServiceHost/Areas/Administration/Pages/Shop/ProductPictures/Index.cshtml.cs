using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Application.Contracts.ProductPicture;


namespace ServiceHost.Areas.Administration.Pages.Shop.ProductPictures
{
    public class IndexModel : PageModel
    {
        [TempData] public string Message { get; set; }
        public ProductPictureSearchModel SearchModel;
        public List<ProductPictureViewModel> Productpictures;
        public SelectList products;

        private readonly IProductPictureApplication _productPictureApplication;
        private readonly IProductApplication _productApplication;

        public IndexModel(IProductApplication productApplication, IProductPictureApplication productPictureApplication)
        {
            _productPictureApplication = productPictureApplication;
            _productApplication = productApplication;
        }

        public void OnGet(ProductPictureSearchModel searchModel)
        {
            products = new SelectList(_productApplication.GetProducts(),"Id","Name");
            Productpictures = _productPictureApplication.search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProductPicture
            {
                Products = _productApplication.GetProducts()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateProductPicture command)
        {
            var result = _productPictureApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var productPicture = _productPictureApplication.GetDetails(id);
            productPicture.Products = _productApplication.GetProducts();
            return Partial("Edit", productPicture);
        }

        public JsonResult OnPostEdit(EditProductPicture command)
        {
            var result = _productPictureApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
           var result =  _productPictureApplication.Remove(id);
           if (result.IsSucceeded)
           {
               return RedirectToPage("./Index");
           }

           Message = result.Message;
           return RedirectToPage("./index");
        }
        public IActionResult OnGetRestore(long id)
        {
            var result = _productPictureApplication.Restore(id);
            if (result.IsSucceeded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./index");
        }
    }
}

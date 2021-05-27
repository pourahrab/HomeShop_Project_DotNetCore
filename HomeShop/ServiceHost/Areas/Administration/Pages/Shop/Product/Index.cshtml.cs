using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;


namespace ServiceHost.Areas.Administration.Pages.Shop.Product
{
    public class IndexModel : PageModel
    {
        [TempData] public string Message { get; set; }
        public ProductSearchModel SearchModel;
        public List<ProductViewModel> Products;
        public SelectList productCategories;

        private readonly IProductCategoryApplication _productCategoryApplication;
        private readonly IProductApplication _productApplication;

        public IndexModel(IProductApplication productApplication, IProductCategoryApplication productCategoryApplication)
        {
            _productCategoryApplication = productCategoryApplication;
            _productApplication = productApplication;
        }

        public void OnGet(ProductSearchModel searchModel)
        {
            productCategories = new SelectList(_productCategoryApplication.GetProductCategories(),"Id","Name");
            Products = _productApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateProduct
            {
                Categories = _productCategoryApplication.GetProductCategories()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateProduct command)
        {
            var result = _productApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var product = _productApplication.GetDetails(id);
            product.Categories = _productCategoryApplication.GetProductCategories();
            return Partial("Edit", product);
        }

        public JsonResult OnPostEdit(EditProduct command)
        {
            var result = _productApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetNotInStock(long id)
        {
           var result =  _productApplication.NotInStock(id);
           if (result.IsSucceeded)
           {
               return RedirectToPage("./Index");
           }

           Message = result.Message;
           return RedirectToPage("./index");
        }
        public IActionResult OnGetIsStock(long id)
        {
            var result = _productApplication.IsStock(id);
            if (result.IsSucceeded)
            {
                return RedirectToPage("./Index");
            }

            Message = result.Message;
            return RedirectToPage("./index");
        }
    }
}

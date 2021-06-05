using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_HomeShopQuery.Contracts.ProductCategory;
using ShopManagement.Infrastructure.EFCore;

namespace _01_HomeShopQuery.Query
{
   public class ProductCategoryQuery:IProductCategoryQuery
   {
       private readonly ShopContext _context;

       public ProductCategoryQuery(ShopContext context)
       {
           _context = context;
       }

       public List<Contracts.ProductCategory.ProductCategoryQueryModel> GetProductCategories()
       {
           return _context.ProductCategories.Select(x => new ProductCategoryQueryModel
           {
               Id = x.Id,
               Name = x.Name,
               Picture = x.Picture,
               PictureAlt = x.PictureAlt,
               PictureTitle = x.PictureTitle,
               Slug = x.Slug
           }).ToList();
       }
    }
}

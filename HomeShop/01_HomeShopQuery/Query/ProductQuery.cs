using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_HomeShopQuery.Contracts.Product;
using ShopManagement.Infrastructure.EFCore;

namespace _01_HomeShopQuery.Query
{
    
  public  class ProductQuery:IProductQuery
  {
      private readonly ShopContext _context;

      public ProductQuery(ShopContext context)
      {
          _context = context;
      }

      public List<ProductQueryModel> GetProducts()
      {
          return _context.Products.Select(x => new ProductQueryModel
          {
              Id = x.Id,
              Name = x.Name,
              Picture = x.Picture,
              PictureAlt = x.PictureAlt,
              PictureTitle = x.PictureTitle,
              Code = x.Code,
              Slug = x.Slug
          }).ToList();
      }
    }
}

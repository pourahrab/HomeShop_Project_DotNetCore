using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HomeShopQuery.Contracts.Product
{
   public class ProductQueryModel
    {
        public long Id { get; set; } 
        public string Name { get;   set; }
        public string Code { get;   set; }
      //  public double UnitPrice { get;   set; }
       // public bool IsInStock { get;   set; }
     //   public string ShortDescription { get;   set; }
      //  public string Description { get;   set; }
        public string Picture { get;   set; }
        public string PictureAlt { get;   set; }
        public string PictureTitle { get;   set; }
    //    public long CategoryId { get;   set; }
        public string Slug { get;   set; }
      //  public string Keywords { get;   set; }
      //  public string MetaDescription { get;   set; }
    }
}

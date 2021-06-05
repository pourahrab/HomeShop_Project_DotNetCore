using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HomeShopQuery.Contracts.Product
{
   public interface IProductQuery
   {
       List<ProductQueryModel> GetProducts();
   }
}

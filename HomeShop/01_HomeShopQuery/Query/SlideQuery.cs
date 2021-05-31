using System;
using System.Collections.Generic;
using System.Linq;
using _01_HomeShopQuery.Contracts.Slide;
using ShopManagement.Infrastructure.EFCore;

namespace _01_HomeShopQuery.Query
{
   public class SlideQuery:ISlideQuery
    {
        private readonly ShopContext _shopcontext;

        public SlideQuery(ShopContext shopcontext)
        {
            _shopcontext = shopcontext;
        }

        public List<SlideQueryModel> GetSlides()
        {
            return _shopcontext.slides.Where(x=>x.IsRemoved==false).Select(x => new SlideQueryModel
            {
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                BtnText = x.BtnText,
                Heading = x.Heading,
                Link = x.Link,
                Text = x.Text,
                Title = x.Title
            }).ToList();
        }
    }
}

using ShopManagement.Application.Contracts.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManegement.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _iProductCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository iProductCategoryRepository)
        {
            _iProductCategoryRepository = iProductCategoryRepository;
        }
        public OperationResult Create(CreateProductCategory command)
        {
            var operation = new OperationResult();
            if (_iProductCategoryRepository.Exists(x => x.Name == command.Name))
                return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد.");

            var slug = command.Slug.Slugify();
            var productcategory = new ProductCategory(command.Name, command.Description, command.Picture, command.PictureAlt, command.PictureTitle, command.Keywords, command.MetaDescription, slug);
            _iProductCategoryRepository.Create(productcategory);
            _iProductCategoryRepository.Save();
            return operation.Succedded();
        }

        public OperationResult Edit(EditProductCategory command)
        {
            var operation = new OperationResult();
            var productcategory = _iProductCategoryRepository.Get(command.Id);
            if (productcategory == null)
                return operation.Failed("رکورد مورد نظر وجود ندارد");

            if(_iProductCategoryRepository.Exists(x=> x.Name == command.Name && x.Id != x.Id ))
                return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد.");

            var slug = command.Slug.Slugify();
            productcategory.Edit(command.Name,command.Description,command.Picture,command.PictureAlt,command.PictureTitle,command.Keywords,command.MetaDescription, slug);

            _iProductCategoryRepository.Save();
            return operation.Succedded();
        }

        public EditProductCategory GetDetails(long id)
        {
            return _iProductCategoryRepository.GetDetails(id);
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            return _iProductCategoryRepository.Search(searchModel);
        }
    }
}

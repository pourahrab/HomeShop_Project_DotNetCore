using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductPicture;
using ShopManagement.Domain.ProductPictureAgg;

namespace ShopManegement.Application
{
   public class ProductPictureApplication:IProductPictureApplication
   {
       private readonly IProductPictureRepository _productPictureRepository;

       public ProductPictureApplication(IProductPictureRepository productPictureRepository)
       {
           _productPictureRepository = productPictureRepository;
       }

       public OperationResult Create(CreateProductPicture command)
        {
            var operation = new OperationResult();
            if (_productPictureRepository.Exists(x=>x.Picture == command.Picture && x.ProductId == command.ProductId))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }
            var productpicture = new ProductPicture(command.ProductId,command.Picture,command.PictureAlt,command.PictureTitle);
            _productPictureRepository.Create(productpicture);
            _productPictureRepository.Save();
            return operation.Succeeded();
        }

        public OperationResult Edit(EditProductPicture command)
        {
            var operation = new OperationResult();
            var productpicture = _productPictureRepository.Get(command.Id);
            if (productpicture == null)
            {
                operation.Failed(ApplicationMessages.RecordNotFound);
            }

            if (_productPictureRepository.Exists(x=>x.Picture == command.Picture && x.ProductId == command.ProductId && x.Id != command.Id))
            {
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            }
            productpicture.Edit(command.ProductId,command.Picture,command.PictureAlt,command.PictureTitle);
            _productPictureRepository.Save();
           return operation.Succeeded();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var productpicture = _productPictureRepository.Get(id);
            if (productpicture == null)
            {
                operation.Failed(ApplicationMessages.RecordNotFound);
            }

            productpicture.Remove();
            _productPictureRepository.Save();
            return operation.Succeeded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var productpicture = _productPictureRepository.Get(id);
            if (productpicture == null)
            {
                operation.Failed(ApplicationMessages.RecordNotFound);
            }

            productpicture.Restore();
            _productPictureRepository.Save();
            return operation.Succeeded();
        }

        public EditProductPicture GetDetails(long id)
        {
            return _productPictureRepository.GetDetails(id);
        }

        public List<ProductPictureViewModel> search(ProductPictureSearchModel searchModel)
        {
            return _productPictureRepository.search(searchModel);
        }
    }
}

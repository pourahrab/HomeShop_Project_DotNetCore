﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.Slide;
using ShopManagement.Domain.SliderAgg;

namespace ShopManegement.Application
{
  public  class SlideApplication:ISlideApplication
  {
      private readonly ISlideRepository _slideRepository;

      public SlideApplication(ISlideRepository slideRepository)
      {
          _slideRepository = slideRepository;
      }

      public OperationResult Create(CreateSlide command)
        {
            var operation = new OperationResult();
            var slide = new Slide(command.Picture,command.PictureAlt,command.PictureTitle,command.Heading,command.Title,command.Text,command.BtnText);

            _slideRepository.Create(slide);
            _slideRepository.Save();
            return operation.Succeeded();
        }

        public OperationResult Edit(EditSlide command)
        {
            var operation = new OperationResult();
            var slide = _slideRepository.Get(command.Id);

            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            slide.Edit(command.Picture,command.PictureAlt,command.PictureTitle,command.Heading,command.Title,command.Text,command.BtnText);

            _slideRepository.Save();
            return operation.Succeeded();
        }

        public OperationResult Remove(long id)
        {

            var operation = new OperationResult();
            var slide = _slideRepository.Get(id);

            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            slide.Remove();

            _slideRepository.Save();
            return operation.Succeeded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var slide = _slideRepository.Get(id);

            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            slide.Restore();

            _slideRepository.Save();
            return operation.Succeeded();
        }

        public EditSlide GetDetails(long id)
        {
            return _slideRepository.GetDetails(id);
        }

        public List<SlideViewModel> GetList()
        {
            return _slideRepository.GetList();
        }
    }
}
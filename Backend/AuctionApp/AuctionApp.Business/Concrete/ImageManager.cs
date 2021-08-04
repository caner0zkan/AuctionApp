using AuctionApp.Business.Abstract;
using AuctionApp.DataAccess.Abstract;
using AuctionApp.DataAccess.Concrete;
using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Concrete
{
    public class ImageManager : IImageService
    {
        private IImageRepository _imageRepository;
        public ImageManager()
        {
            _imageRepository = new ImageRepository();
        }

        public Image Create(Image entity)
        {
            return _imageRepository.Create(entity);
        }

        public void Delete(Image entity)
        {
            _imageRepository.Delete(entity);
        }

        public List<Image> GetAll()
        {
            return _imageRepository.GetAll();
        }

        public Image GetById(int id)
        {
            return _imageRepository.GetById(id);
        }

        public Image Update(Image entity)
        {
            return _imageRepository.Update(entity);
        }
    }
}

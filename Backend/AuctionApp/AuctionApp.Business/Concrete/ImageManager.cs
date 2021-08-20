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
        public ImageManager(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public void Create(Image entity)
        {
            _imageRepository.Create(entity);
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

        public void Update(Image entity)
        {
            _imageRepository.Update(entity);
        }
    }
}

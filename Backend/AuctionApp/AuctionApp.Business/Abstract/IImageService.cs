using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Abstract
{
    public interface IImageService
    {
        List<Image> GetAll();

        Image GetById(int id);

        Image Create(Image entity);

        Image Update(Image entity);

        void Delete(Image entity);
    }
}

using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Abstract
{
    interface ICategoryService
    {
        List<Category> GetAll();

        Category GetById(int id);

        Category Create(Category entity);

        Category Update(Category entity);

        void Delete(Category entity);
    }
}

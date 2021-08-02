using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Abstract
{
    interface IUserService
    {
        List<User> GetAll();

        User GetById(int id);

        User Create(User entity);

        User Update(User entity);

        void Delete(User entity);
    }
}

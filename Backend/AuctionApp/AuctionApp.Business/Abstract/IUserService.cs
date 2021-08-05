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

        void Create(User entity);

        void Update(User entity);

        void Delete(User entity);
    }
}

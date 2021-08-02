using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Abstract
{
    interface IAdminService
    {
        List<Admin> GetAll();

        Admin GetById(int id);

        Admin Create(Admin entity);

        Admin Update(Admin entity);

        void Delete(Admin entity);
    }
}

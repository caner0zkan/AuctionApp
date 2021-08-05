using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetAll();

        Admin GetById(int id);

        void Create(Admin entity);

        void Update(Admin entity);

        void Delete(Admin entity);
    }
}

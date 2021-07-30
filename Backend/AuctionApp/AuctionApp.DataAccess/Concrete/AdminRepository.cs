using AuctionApp.DataAccess.Abstract;
using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.DataAccess.Concrete
{
    class AdminRepository : IAdminRepository
    {
        public Admin CreateAuction(Admin entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuction(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAllAuctions()
        {
            throw new NotImplementedException();
        }

        public Admin GetAuctionById(int id)
        {
            throw new NotImplementedException();
        }

        public Admin UpdateAuction(Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}

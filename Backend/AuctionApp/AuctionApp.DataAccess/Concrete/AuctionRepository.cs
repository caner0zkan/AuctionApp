using AuctionApp.DataAccess.Abstract;
using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.DataAccess.Concrete
{
    public class AuctionRepository : IAuctionRepository
    {
        public Auction CreateAuction(Auction auction)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuction(int id)
        {
            throw new NotImplementedException();
        }

        public List<Auction> GetAllAuctions()
        {
            throw new NotImplementedException();
        }

        public Auction GetAuctionById(int id)
        {
            throw new NotImplementedException();
        }

        public Auction UpdateAuction(Auction auction)
        {
            throw new NotImplementedException();
        }
    }
}

using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace AuctionApp.Business.Abstract
{
    public interface IAuctionService
    {
        List<Auction> GetAll();

        Auction GetById(int id);

        Auction Create(Auction entity);

        Auction Update(Auction entity);

        void Delete(Auction entity);
    }
}

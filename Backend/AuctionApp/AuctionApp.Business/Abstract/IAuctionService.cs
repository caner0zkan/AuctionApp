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

        void Create(Auction entity);

        void Update(Auction entity);

        void Delete(Auction entity);
    }
}

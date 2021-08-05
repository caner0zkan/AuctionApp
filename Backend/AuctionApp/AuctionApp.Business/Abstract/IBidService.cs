using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Abstract
{
    interface IBidService
    {
        List<Bid> GetAll();

        Bid GetById(int id);

        void Create(Bid entity);

        void Update(Bid entity);

        void Delete(Bid entity);
    }
}

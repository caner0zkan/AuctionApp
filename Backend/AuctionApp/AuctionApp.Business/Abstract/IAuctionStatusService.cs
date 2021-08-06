using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Abstract
{
    public interface IAuctionStatusService
    {
        List<AuctionStatus> GetAll();

        AuctionStatus GetById(int id);

        void Create(AuctionStatus entity);

        void Update(AuctionStatus entity);

        void Delete(AuctionStatus entity);
    }
}

using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Abstract
{
    interface IAuctionStatusService
    {
        List<AuctionStatus> GetAll();

        AuctionStatus GetById(int id);

        AuctionStatus Create(AuctionStatus entity);

        AuctionStatus Update(AuctionStatus entity);

        void Delete(AuctionStatus entity);
    }
}

using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.DataAccess.Abstract
{
    public interface IBidRepository: IRepository<Auction>
    {
    }
}

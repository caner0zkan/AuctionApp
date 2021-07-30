using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAllAuctions();

        T GetAuctionById(int id);

        T CreateAuction(T entity);

        T UpdateAuction(T entity);

        void DeleteAuction(int id);
    }
}

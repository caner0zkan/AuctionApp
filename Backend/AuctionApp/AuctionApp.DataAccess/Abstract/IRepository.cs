using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.DataAccess.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T GetById(int id);

        T Create(T entity);

        T Update(T entity);

        void Delete(T entity);
    }
}

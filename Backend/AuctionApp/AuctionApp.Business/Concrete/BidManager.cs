using AuctionApp.Business.Abstract;
using AuctionApp.DataAccess.Abstract;
using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Concrete
{
    class BidManager : IBidService
    {
        private IBidRepository _bidRepository;
        public BidManager(IBidRepository bidRepository)
        {
            _bidRepository = bidRepository;
        }

        public Bid Create(Bid entity)
        {
            return _bidRepository.Create(entity);
        }

        public void Delete(Bid entity)
        {
            _bidRepository.Create(entity);
        }

        public List<Bid> GetAll()
        {
            return _bidRepository.GetAll();
        }

        public Bid GetById(int id)
        {
            return _bidRepository.GetById(id);
        }

        public Bid Update(Bid entity)
        {
            return _bidRepository.Update(entity);
        }
    }
}

using AuctionApp.Business.Abstract;
using AuctionApp.DataAccess.Abstract;
using AuctionApp.DataAccess.Concrete;
using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Concrete
{
    public class BidManager : IBidService
    {
        private IBidRepository _bidRepository;
        public BidManager()
        {
            _bidRepository = new BidRepository();
        }

        public void Create(Bid entity)
        {
            _bidRepository.Create(entity);
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

        public void Update(Bid entity)
        {
            _bidRepository.Update(entity);
        }
    }
}

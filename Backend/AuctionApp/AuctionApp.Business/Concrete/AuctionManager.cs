using AuctionApp.Business.Abstract;
using AuctionApp.DataAccess.Abstract;
using AuctionApp.DataAccess.Concrete;
using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Concrete
{
    public class AuctionManager : IAuctionService
    {
        private IAuctionRepository _auctionRepository;
        public AuctionManager()
        {
            _auctionRepository = new AuctionRepository();
        }

        public void Create(Auction entity)
        {
            _auctionRepository.Create(entity);
        }

        public void Delete(Auction entity)
        {
            _auctionRepository.Delete(entity);
        }

        public List<Auction> GetAll()
        {
            return _auctionRepository.GetAll();
        }

        public Auction GetById(int id)
        {
            if (id > 0)
            {
                return _auctionRepository.GetById(id);
            }

            throw new Exception("id can not be less than 1");
        }

        public void Update(Auction entity)
        {
            _auctionRepository.Update(entity);
        }
    }
}

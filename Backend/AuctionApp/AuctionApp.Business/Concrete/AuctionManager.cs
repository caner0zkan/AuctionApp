using AuctionApp.Business.Abstract;
using AuctionApp.DataAccess.Abstract;
using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Concrete
{
    public class AuctionManager : IAuctionService
    {
        private IAuctionRepository _auctionRepository;
        public AuctionManager(IAuctionRepository auctionRepository)
        {
            _auctionRepository = auctionRepository;
        }

        public Auction Create(Auction entity)
        {
            return _auctionRepository.Create(entity);
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
            return _auctionRepository.GetById(id);
        }

        public Auction Update(Auction entity)
        {
            return _auctionRepository.Update(entity);
        }
    }
}

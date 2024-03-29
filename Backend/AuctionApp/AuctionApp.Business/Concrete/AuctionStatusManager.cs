﻿using AuctionApp.Business.Abstract;
using AuctionApp.DataAccess.Abstract;
using AuctionApp.DataAccess.Concrete;
using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Concrete
{
    public class AuctionStatusManager : IAuctionStatusService
    {
        private IAuctionStatusRepository _auctionStatusRepository;
        public AuctionStatusManager(IAuctionStatusRepository auctionStatusRepository)
        {
            _auctionStatusRepository = auctionStatusRepository;
        }

        public void Create(AuctionStatus entity)
        {
            _auctionStatusRepository.Create(entity);
        }

        public void Delete(AuctionStatus entity)
        {
            _auctionStatusRepository.Delete(entity);
        }

        public List<AuctionStatus> GetAll()
        {
            return _auctionStatusRepository.GetAll();
        }

        public AuctionStatus GetById(int id)
        {
            return _auctionStatusRepository.GetById(id);
        }

        public void Update(AuctionStatus entity)
        {
            _auctionStatusRepository.Update(entity);
        }
    }
}

﻿using AuctionApp.Business.Abstract;
using AuctionApp.Business.Concrete;
using AuctionApp.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private IAuctionService _auctionService;

        public AuctionsController()
        {
            _auctionService = new AuctionManager();
        }

        [HttpGet]
        public List<Auction> Get()
        {
            return _auctionService.GetAll();
        }

        [HttpGet("{id}")]
        public Auction Get(int id)
        {
            return _auctionService.GetById(id);
        }
    }
}
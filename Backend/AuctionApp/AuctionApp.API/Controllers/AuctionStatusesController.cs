using AuctionApp.Business.Abstract;
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
    public class AuctionStatusesController : ControllerBase
    {
        private IAuctionStatusService _auctionStatusService;

        public AuctionStatusesController(IAuctionStatusService auctionStatusService)
        {
            _auctionStatusService = auctionStatusService;
        }

        [HttpGet]
        public List<AuctionStatus> Get()
        {
            return _auctionStatusService.GetAll();
        }

        [HttpGet("{id}")]
        public AuctionStatus Get(int id)
        {
            return _auctionStatusService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] AuctionStatus auctionStatus)
        {
            _auctionStatusService.Create(auctionStatus);
        }

        [HttpPut]
        public void Put([FromBody] AuctionStatus auctionStatus)
        {
            _auctionStatusService.Update(auctionStatus);
        }

        [HttpDelete("{id}")]
        public void Delete(AuctionStatus auctionStatus)
        {
            _auctionStatusService.Delete(auctionStatus);
        }
    }
}

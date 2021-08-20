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
    public class BidsController : ControllerBase
    {
        private IBidService _bidService;

        public BidsController(IBidService bidService)
        {
            _bidService = bidService;
        }

        [HttpGet]
        public List<Bid> Get()
        {
            return _bidService.GetAll();
        }

        [HttpGet("{id}")]
        public Bid Get(int id)
        {
            return _bidService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Bid admin)
        {
            _bidService.Create(admin);
        }

        [HttpPut]
        public void Put([FromBody] Bid admin)
        {
            _bidService.Update(admin);
        }

        [HttpDelete("{id}")]
        public void Delete(Bid admin)
        {
            _bidService.Delete(admin);
        }
    }
}

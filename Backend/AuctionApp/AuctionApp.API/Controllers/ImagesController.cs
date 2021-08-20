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
    public class ImagesController : ControllerBase
    {
        private IImageService _iamgeService;

        public ImagesController(IImageService imageService)
        {
            _iamgeService = imageService;
        }

        [HttpGet]
        public List<Image> Get()
        {
            return _iamgeService.GetAll();
        }

        [HttpGet("{id}")]
        public Image Get(int id)
        {
            return _iamgeService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Image image)
        {
            _iamgeService.Create(image);
        }

        [HttpPut]
        public void Put([FromBody] Image image)
        {
            _iamgeService.Update(image);
        }

        [HttpDelete("{id}")]
        public void Delete(Image image)
        {
            _iamgeService.Delete(image);
        }
    }
}

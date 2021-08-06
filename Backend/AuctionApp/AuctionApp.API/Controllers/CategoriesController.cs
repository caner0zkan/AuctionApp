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
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoriesController()
        {
            _categoryService = new CategoryManager();
        }

        [HttpGet]
        public List<Category> Get()
        {
            return _categoryService.GetAll();
        }

        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _categoryService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Category category)
        {
            _categoryService.Create(category);
        }

        [HttpPut]
        public void Put([FromBody] Category category)
        {
            _categoryService.Update(category);
        }

        [HttpDelete("{id}")]
        public void Delete(Category category)
        {
            _categoryService.Delete(category);
        }
    }
}

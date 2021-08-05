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
    public class AdminsController : ControllerBase
    {
        private IAdminService _adminService;

        public AdminsController()
        {
            _adminService = new AdminManager();
        }

        [HttpGet]
        public List<Admin> Get()
        {
            return _adminService.GetAll();
        }

        [HttpGet("{id}")]
        public Admin Get(int id)
        {
            return _adminService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Admin admin)
        {
            _adminService.Create(admin);
        }

        [HttpPut]
        public void Put([FromBody] Admin admin)
        {
            _adminService.Update(admin);
        }

        [HttpDelete("{id}")]
        public void Delete(Admin admin)
        {
            _adminService.Delete(admin);
        }
    }
}

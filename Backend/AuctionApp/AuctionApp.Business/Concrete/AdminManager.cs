using AuctionApp.Business.Abstract;
using AuctionApp.DataAccess.Abstract;
using AuctionApp.DataAccess.Concrete;
using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Concrete
{
    public class AdminManager : IAdminService
    {
        private IAdminRepository _adminRepository;
        public AdminManager(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public void Create(Admin entity)
        {
            _adminRepository.Create(entity);
        }

        public void Delete(Admin entity)
        {
            _adminRepository.Delete(entity);
        }

        public List<Admin> GetAll()
        {
            return _adminRepository.GetAll();
        }

        public Admin GetById(int id)
        {
            return _adminRepository.GetById(id);
        }

        public void Update(Admin entity)
        {
            _adminRepository.Update(entity);
        }
    }
}

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
        public AdminManager()
        {
            _adminRepository = new AdminRepository();
        }

        public Admin Create(Admin entity)
        {
            return _adminRepository.Create(entity);
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

        public Admin Update(Admin entity)
        {
            return _adminRepository.Update(entity);
        }
    }
}

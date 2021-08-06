using AuctionApp.Business.Abstract;
using AuctionApp.DataAccess.Abstract;
using AuctionApp.DataAccess.Concrete;
using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;
        public UserManager()
        {
            _userRepository = new UserRepository();
        }

        public void Create(User entity)
        {
            _userRepository.Create(entity);
        }

        public void Delete(User entity)
        {
            _userRepository.Delete(entity);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }
    }
}

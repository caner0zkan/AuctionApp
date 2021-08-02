using AuctionApp.Business.Abstract;
using AuctionApp.DataAccess.Abstract;
using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.Business.Concrete
{
    class UserManager : IUserService
    {
        private IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Create(User entity)
        {
            return _userRepository.Create(entity);
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

        public User Update(User entity)
        {
            return _userRepository.Update(entity);
        }
    }
}

using AuctionApp.DataAccess.Abstract;
using AuctionApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.DataAccess.Concrete
{
    public class UserRepository : GenericRepository<User, AuctionDbContext>, IUserRepository
    {
    }
}

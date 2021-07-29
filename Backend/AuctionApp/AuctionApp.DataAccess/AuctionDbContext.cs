using AuctionApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp.DataAccess
{
    public class AuctionDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=CANER\SQLEXPRESS; Database=AuctionDb; uid=sa; pwd=1234;");
        }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<AuctionStatus> AuctionStatuses { get; set; }
    }
}

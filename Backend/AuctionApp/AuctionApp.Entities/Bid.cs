using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AuctionApp.Entities
{
    public class Bid
    {
        public int ID { get; set; }
        public DateTime BidDate { get; set; }

        //FK
        public int UserID { get; set; }
        public User User { get; set; }
        public int AuctionID { get; set; }
        public Auction Auction { get; set; }
    }
}

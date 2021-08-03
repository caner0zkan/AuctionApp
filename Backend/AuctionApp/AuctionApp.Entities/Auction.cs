using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionApp.Entities
{
    public class Auction
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int AuctionNumber { get; set; }
        [StringLength(20)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Comment { get; set; }
        public int Winner { get; set; }
        public DateTime startingDate { get; set; }
        public DateTime endingTime { get; set; }


        public List<Bid> Bids { get; set; }
        public List<Image> Image { get; set; }

        //FK
        public int AdminID { get; set; }
        public Admin Admin { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int AuctionStatusID { get; set; }
        public AuctionStatus AuctionStatus { get; set; }
    }
}

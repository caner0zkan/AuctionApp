using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AuctionApp.Entities
{
    public class AuctionStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(10)]
        public string Status { get; set; }

        public List<Auction> Auctions { get; set; }
    }
}

using System;
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
        public byte[] Image { get; set; }
        public DateTime startingDate { get; set; }
        public DateTime endingTime { get; set; }
    }
}

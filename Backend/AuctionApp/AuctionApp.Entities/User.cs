using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AuctionApp.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Surname { get; set; }
        [StringLength(20)]
        public string Password { get; set; }

        public List<Bid> Bids { get; set; }
    }
}

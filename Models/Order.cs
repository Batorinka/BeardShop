using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeardShop.Models
{
    public class Order
    {
        public int Id { get; set; }      // NotNull
        public int UserId { get; set; } // NotNull
        public DateTime OrderDate { get; set; } // NotNull
        public DateTime? ShipmentDate { get; set; }
        public int? OrderNumber { get; set; }
        public string Status { get; set; }
        public User User { get; set; }
    }
}
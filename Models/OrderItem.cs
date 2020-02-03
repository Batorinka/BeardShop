using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeardShop.Models
{
    public class OrderItem
    {
        public int Id { get; set; }      // NotNull
        public int OrderId { get; set; } // NotNull
        public int ProductId { get; set; } // NotNull
        public int ProductsCount { get; set; } // NotNull
        public Order Order { get; set; }
        public Product Product{ get; set; }
    }
}
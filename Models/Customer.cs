using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeardShop.Models
{
    public class Customer
    {
        public int Id { get; set; }      // NotNull
        public string Name { get; set; } // NotNull
        public string Code { get; set; } // NotNull «ХХХХ-ГГГГ» где Х – число, ГГГГ – год в котором зарегистрирован заказчик
        public string Address { get; set; }
        public int Discount { get; set; }
    }
}

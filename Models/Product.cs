using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeardShop.Models
{
    public class Product
    {
        public int Id { get; set; }      // NotNull
        public string Code { get; set; } // NotNull «XX-XXXX-YYXX» где Х – число , Y- заглавная буква английского алфавита
        public string Name{ get; set; } // NotNull
        public int Price { get; set; } // NotNull
        public string Category { get; set; } // NotNull
    }
}
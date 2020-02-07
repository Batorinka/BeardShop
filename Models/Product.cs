using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeardShop.Models
{
    public class Product
    {
        public int Id { get; set; }      // NotNull
        [Required]
        public string Code { get; set; } // NotNull «XX-XXXX-YYXX» где Х – число , Y- заглавная буква английского алфавита
        public string Name{ get; set; } 
        public int? Price { get; set; }
        [MaxLength(30)]
        public string Category { get; set; }
    }
}
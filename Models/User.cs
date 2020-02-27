using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeardShop.Models
{
    public class User
    {
        public int Id { get; set; }      // NotNull
        [Required]
        public string Name { get; set; } // NotNull
        [Required]
        public string Email { get; set; } // NotNull
        [Required]
        public string Password { get; set; } // NotNull
        [Required]
        public string Code { get; set; } // NotNull «ХХХХ-ГГГГ» где Х – число, ГГГГ – год в котором зарегистрирован заказчик
        public int? RoleId { get; set; } // 1 - Admin, 2 - Customer
        public Role Role { get; set; }
        public string Address { get; set; }
        public int? Discount { get; set; }
    }
}

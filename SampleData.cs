using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeardShop.Models;

namespace BeardShop
{
    public class SampleData
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Code = "01-1234-AV32",
                        Name = "Масло для бороды Borodist Emerald 15 мл",
                        Price = 500,
                        Category = "Масла"
                    },
                    new Product
                    {
                        Code = "01-4324-AC62",
                        Name = "Масло для бороды Borodist Hunter 20 мл",
                        Price = 600,
                        Category = "Масла"
                    },
                    new Product
                    {
                        Code = "01-4546-AC64",
                        Name = "Масло для бороды Borodist Irish Whiskey 30 мл",
                        Price = 800,
                        Category = "Масла"
                    },
                    new Product
                    {
                        Code = "02-4984-TJ27",
                        Name = "Т-образная бритва Edwin Jagger CSR Chatsworth хром",
                        Price = 6290,
                        Category = "Бритвы"
                    },
                    new Product
                    {
                        Code = "02-7774-TJ25",
                        Name = "Т-образная бритва Edwin Jagger DE87BL слоновая кость",
                        Price = 2890,
                        Category = "Бритвы"
                    }
                );
            }
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Name = "Admin",
                        Email = "admin@beardshop.com",
                        Password = "123",
                        Role = 1,
                        Code = "0401-2020"
                    },
                    new User
                    {
                        Name = "Kirill",
                        Email = "kirill@beardshop.com",
                        Password = "123",
                        Role = 2,
                        Code = "1001-2020",
                        Address = "Stupino",
                        Discount = 10
                    },
                    new User
                    {
                        Name = "Kostya",
                        Email = "kostya@beardshop.com",
                        Password = "123",
                        Role = 2,
                        Code = "1001-2020",
                        Address = "Kolomna",
                        Discount = 0
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication22.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        static public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product { Id = 1, Name = "Product_1", Price = 10.102m, Description = "http://www.porus.me" });
            list.Add(new Product { Id = 1, Name = "Product_2", Price = 11.102m, Description = "Text_2" });
            list.Add(new Product { Id = 1, Name = "Product_3", Price = 12.012m, Description = "Text_3" });
            list.Add(new Product { Id = 1, Name = "Product_4", Price = 13.014m, Description = "Text_4" });
            list.Add(new Product { Id = 1, Name = "Product_5", Price = 14.012m, Description = "Text_5" });
            
            return list;
        }
    }
}
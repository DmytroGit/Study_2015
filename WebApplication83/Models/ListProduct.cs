using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication83.Models
{
    public class ListProduct
    {
        public static List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product { Id = 1, Name = "Продукт 1", Price = 11.01m, Description = "Описание продукта 1" });
            list.Add(new Product { Id = 2, Name = "Продукт 2", Price = 12.01m, Description = "Описание продукта 2" });
            list.Add(new Product { Id = 3, Name = "Продукт 3", Price = 13.01m, Description = "Описание продукта 3" });
            list.Add(new Product { Id = 4, Name = "Продукт 4", Price = 14.01m, Description = "Описание продукта 4" });
            list.Add(new Product { Id = 5, Name = "Продукт 5", Price = 15.01m, Description = "Описание продукта 5" });
            list.Add(new Product { Id = 6, Name = "Продукт 6", Price = 16.01m, Description = "Описание продукта 6" });
            list.Add(new Product { Id = 7, Name = "Продукт 7", Price = 17.01m, Description = "Описание продукта 7" });
            list.Add(new Product { Id = 8, Name = "Продукт 8", Price = 18.01m, Description = "Описание продукта 8" });
            list.Add(new Product { Id = 9, Name = "Продукт 9", Price = 19.01m, Description = "Описание продукта 9" });

            return list;
        }
    }
}
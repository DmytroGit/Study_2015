using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication83.Models
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Price { set; get; }
        public string Description { set; get; }
    }
}
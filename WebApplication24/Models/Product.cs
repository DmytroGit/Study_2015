using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication24.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public decimal IPrice { get; set; }
        public string Description { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
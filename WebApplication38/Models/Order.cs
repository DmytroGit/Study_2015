using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication38.Models
{
    public class Order
    {
        [Required(ErrorMessage ="Поле обязательно для заполнения")]
        public string Name { get; set; }
    }
}
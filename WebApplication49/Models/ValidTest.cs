using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication49.Models
{
    public class ValidTest
    {
        [Required(ErrorMessage = "Стартовая дата обязательна")]
        public string StartDate { get; set; }

        [Required(ErrorMessage = "Финишная дата обязательна")]
        public string FinishDate { get; set; }
    }
}
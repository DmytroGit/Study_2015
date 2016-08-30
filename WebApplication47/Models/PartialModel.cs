using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication47.Models
{
    public class PartialModel
    {
        [Required(ErrorMessage = "Id обязательно")]
        public int Id { set; get; }

        [Required(ErrorMessage = "Name обязательно")]
        public string Name { set; get; }
    }
}
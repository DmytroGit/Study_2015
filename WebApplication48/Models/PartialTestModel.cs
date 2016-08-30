using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication48.Models
{
    public class PartialTestModel
    {
        [Required(ErrorMessage ="Id обязательно")]
        public int Id { set; get; }

        [Required(ErrorMessage = "Name обязательно")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Old обязательно")]
        public int Old { set; get; }
    }
}
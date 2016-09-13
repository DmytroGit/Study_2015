using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication86.Models
{
    public class PhoneModel
    {
        [Display(Name = "Код страны")]
        public int codeCountry { get; set; }

        [Display(Name = "Код города")]
        public int codeSity { get; set; }

        [Display(Name = "Номер абонента")]
        public int numAbonent { get; set; }
    }
}
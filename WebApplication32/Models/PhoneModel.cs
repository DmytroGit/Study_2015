using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication32.Models
{
    public class PhoneModel
    {
        [Display(Name ="Код страны")]
        public string codeCountry { get; set; }
        [Display(Name = "Код города")]
        public string codeSity { get; set; }
        [Display(Name = "Номер абонента")]
        public string numberAbonent { get; set; }

       public static PhoneModel GetPhone()
        {
            PhoneModel pM = new PhoneModel();
            
            pM.codeCountry = "111";
            pM.codeSity = "222";
            pM.numberAbonent = "3333333";

            return pM;
        }
    }
}
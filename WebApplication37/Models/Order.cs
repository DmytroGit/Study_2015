using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication37.Models
{
    public class Order
    {
        [Required(ErrorMessage = "Имя обязательно")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Следует указать пароль от 5 до 20 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Адрес обязательный")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email обязательный")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Дата обязательна")]
        [DataType(DataType.Date)]
        public string Date { get; set; }

        [Required(ErrorMessage = "Флаг обязательно")]
        public bool TermsAccepted { get; set; }
    }
}
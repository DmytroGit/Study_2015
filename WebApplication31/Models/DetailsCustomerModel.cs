using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication31.Models
{
    public class DetailsCustomerModel
    {
        [Required(ErrorMessage = "ИД обязательно")]
        [Display(Name = "ИД пользователя")]
        public int Id { set; get; }

        [Required(ErrorMessage = "Имя обязательно")]
        [Display(Name = "Имя пользователя")]
        public string FirstName { set; get; }

        [Required(ErrorMessage = "Фамилия обязательна")]
        [Display(Name = "Фамилия пользователя")]
        public string LastName { set; get; }
    }
}
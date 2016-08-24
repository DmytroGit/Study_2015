using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication33.Models
{
    public class Order
    {
        [Required(ErrorMessage = "Вы не ввели логин")]
        [StringLength(10, ErrorMessage = "Логин не может привышать 10 символов")]
        public string Login { get; set; }
        
        [Required(ErrorMessage = "Поле Email обязательно для заполнения")]
        [RegularExpression(@"(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Email адрес указан не правильно")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле Age обязательно для заполнения")]
        [Range(18, 60, ErrorMessage = "Значение поля возраст должно попадать в диапазон от 18 до 60")]
        public int Age { get; set; }
    }
}
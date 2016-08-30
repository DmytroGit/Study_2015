using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication31.Models
{
    public class DetailsDateToDateModel
    {
        [Required(ErrorMessage = "Дата начала переода обязательна к заполнению")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата начала периода")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Дата окончания периода обязательна к заполнению")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата окончания периода")]
        public DateTime FinishDate { get; set; }
    }
}
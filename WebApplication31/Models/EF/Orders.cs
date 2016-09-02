//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication31.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Orders
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Количество продукта обязательно для заплнения")]
        [Display(Name = "Количество продукта")]
        public int CountProduct { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Дата заказа обязательна для заплнения")]
        [Display(Name = "Дата заказа")]
        public System.DateTime DateOrder { get; set; }

        [Required(ErrorMessage = "Продукт обязательный для заплнения")]
        [Display(Name = "Продукт")]
        public int Products_Id { get; set; }

        [Required(ErrorMessage = "Пользователь обязательный для заплнения")]
        [Display(Name = "Пользователь")]
        public int Customers_Id { get; set; }


        public virtual Customers Customers { get; set; }

        public virtual Products Products { get; set; }
    }
}

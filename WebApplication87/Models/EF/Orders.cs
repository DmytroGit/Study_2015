//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication87.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Orders
    {
        [Display(Name ="ИД заказа")]
        public int OrderId { get; set; }

        [Display(Name = "Количество заказанного товара")]
        public int OrderCountProduct { get; set; }

        [Display(Name = "Дата заказа")]
        [DataType(DataType.Date)]
        public System.DateTime OrderDateOrder { get; set; }

        [Display(Name = "Выбрать продукт")]
        public int OrderProducts_Id { get; set; }

        [Display(Name = "Выбрать пользователя")]
        public int OrderUser_Id { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual Users Users { get; set; }
    }
}

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
        public int CountProduct { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime DateOrder { get; set; }
        public int Products_Id { get; set; }
        public int Orders_Id { get; set; }

        public virtual Customers Customers { get; set; }
        public virtual Products Products { get; set; }
    }
}

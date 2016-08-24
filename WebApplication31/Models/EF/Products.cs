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

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int Id { get; set; }

        [Required(ErrorMessage = "Имя продукта обязательно для заполнения")]
        [StringLength(100)]
        public string NameProduct { get; set; }

        [Required(ErrorMessage = "Цена обязательна для заполнения")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Описание обязательна для заполнения")]
        [UIHint("MultilineText")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Дата обязательна для заполнения")]
        [DataType(DataType.Date)]
        public System.DateTime DateAdd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp12.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class DishCompound
    {
        public long Dish { get; set; }
        public long Ingredient { get; set; }
        public decimal Volume { get; set; }
    
        public virtual Dish Dish1 { get; set; }
        public virtual Ingredient Ingredient1 { get; set; }
    }
}

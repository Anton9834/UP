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
    
    public partial class Order
    {
        public long ID { get; set; }
        public string Client { get; set; }
        public string Employee { get; set; }
        public System.DateTime Date { get; set; }
        public string Status { get; set; }
    
        public virtual Client Client1 { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual OrderCompound OrderCompound { get; set; }
    }
}

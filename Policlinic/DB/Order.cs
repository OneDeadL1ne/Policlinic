//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Policlinic.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int IdOrder { get; set; }
        public int IdAppointment { get; set; }
        public int IdPatient { get; set; }
        public decimal TotalPrice { get; set; }
    
        public virtual Appointment Appointment { get; set; }
        public virtual Patient Patient { get; set; }
    }
}

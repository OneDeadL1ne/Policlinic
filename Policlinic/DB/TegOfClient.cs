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
    
    public partial class TegOfClient
    {
        public int ID { get; set; }
        public int PatientId { get; set; }
        public string Tag { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}

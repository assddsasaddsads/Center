//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Center
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReceptionSet
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public int IdJobless { get; set; }
        public int IdStaff { get; set; }
    
        public virtual JoblessSet JoblessSet { get; set; }
        public virtual StaffSet StaffSet { get; set; }
    }
}
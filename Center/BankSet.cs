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
    
    public partial class BankSet
    {
        public int Id { get; set; }
        public string Job { get; set; }
        public string Need { get; set; }
        public string Income { get; set; }
        public string Arranget { get; set; }
        public int IdEmployer { get; set; }
        public int IdStaff { get; set; }
        public string Selection { get; set; }
    
        public virtual EmployerSet EmployerSet { get; set; }
        public virtual StaffSet StaffSet { get; set; }
    }
}

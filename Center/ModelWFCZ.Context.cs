﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WFCenterEntities1 : DbContext
    {
        public WFCenterEntities1()
            : base("name=WFCenterEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BankSet> BankSet { get; set; }
        public virtual DbSet<EmployerSet> EmployerSet { get; set; }
        public virtual DbSet<JoblessSet> JoblessSet { get; set; }
        public virtual DbSet<MagazineSet> MagazineSet { get; set; }
        public virtual DbSet<ReceptionSet> ReceptionSet { get; set; }
        public virtual DbSet<StaffSet> StaffSet { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
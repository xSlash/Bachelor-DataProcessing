﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CustomerEntities : DbContext
    {
        public CustomerEntities()
            : base("name=CustomerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Main_Bridge_Customer_UnitSet> Main_Bridge_Customer_UnitSet { get; set; }
        public virtual DbSet<Main_Dim_CustomerSet> Main_Dim_CustomerSet { get; set; }
        public virtual DbSet<Main_Dim_UnitSet> Main_Dim_UnitSet { get; set; }
        public virtual DbSet<Main_Fact_LogsSet> Main_Fact_LogsSet { get; set; }
        public virtual DbSet<Main_UsersSet> Main_UsersSet { get; set; }
    }
}
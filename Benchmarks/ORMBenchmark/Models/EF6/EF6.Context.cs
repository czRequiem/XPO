﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORMBenchmark.Models.EF6
{
    using System;
    using System.Data.Entity;
    using System.Configuration;
    using System.Data.Entity.Infrastructure;
    
    public partial class EF6Context : DbContext
    {
        public EF6Context()
            : base(string.Format(ConfigurationManager.ConnectionStrings["EF6ConnectionStringTemplate"].ConnectionString, 
            ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EF6Entity> Entities { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FourthCoffee.Employees
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FourthCoffeeEntities : DbContext
    {
        public FourthCoffeeEntities()
            : base("name=FourthCoffeeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<JobTitles> JobTitles { get; set; }
    }
}

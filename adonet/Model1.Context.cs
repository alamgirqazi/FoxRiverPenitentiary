﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace adonet
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FoxRiverDBEntities : DbContext
    {
        public FoxRiverDBEntities()
            : base("name=FoxRiverDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<crime_table> crime_table { get; set; }
        public virtual DbSet<prisoner_crime> prisoner_crime { get; set; }
        public virtual DbSet<prisoner_info_table> prisoner_info_table { get; set; }
        public virtual DbSet<prisoner_propertyandcash> prisoner_propertyandcash { get; set; }
    }
}

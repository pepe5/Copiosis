﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Copiosis_Application.DB_Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CopiosisEntities : DbContext
    {
        public CopiosisEntities()
            : base("name=CopiosisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<itemClass> itemClasses { get; set; }
        public virtual DbSet<location> locations { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<transaction> transactions { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<webpages_Roles> webpages_Roles { get; set; }
    }
}

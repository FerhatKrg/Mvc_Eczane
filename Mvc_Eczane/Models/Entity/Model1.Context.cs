﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc_Eczane.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbEczaneOtomasyonEntities : DbContext
    {
        public DbEczaneOtomasyonEntities()
            : base("name=DbEczaneOtomasyonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLECZANE> TBLECZANE { get; set; }
        public virtual DbSet<TBLILAC> TBLILAC { get; set; }
        public virtual DbSet<TBLKATEGORI> TBLKATEGORI { get; set; }
        public virtual DbSet<TBLPERSONEL> TBLPERSONEL { get; set; }
        public virtual DbSet<TBLSATIS> TBLSATIS { get; set; }
        public virtual DbSet<TBLILETISIM> TBLILETISIM { get; set; }
        public virtual DbSet<TBLKASA> TBLKASA { get; set; }
    }
}

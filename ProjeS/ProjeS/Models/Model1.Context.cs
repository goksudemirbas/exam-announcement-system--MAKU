﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjeS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SinavİlanEntities : DbContext
    {
        public SinavİlanEntities()
            : base("name=SinavİlanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Bolums> Bolums { get; set; }
        public virtual DbSet<Ders> Ders { get; set; }
        public virtual DbSet<Kullanicis> Kullanicis { get; set; }
        public virtual DbSet<Saats> Saats { get; set; }
        public virtual DbSet<Salons> Salons { get; set; }
        public virtual DbSet<Sinavİlan> Sinavİlan { get; set; }
        public virtual DbSet<Sinifs> Sinifs { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIEI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aplica> Aplica { get; set; }
        public virtual DbSet<Area_Trabajo> Area_Trabajo { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Puesto> Puesto { get; set; }
        public virtual DbSet<Requerimiento> Requerimiento { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<Telefono_Empresa> Telefono_Empresa { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormotsDAL
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
    
        public virtual DbSet<appelant_medecins> appelant_medecins { get; set; }
        public virtual DbSet<global_users> global_users { get; set; }
        public virtual DbSet<dossiers> dossiers { get; set; }
        public virtual DbSet<formulaire_act> formulaire_act { get; set; }
        public virtual DbSet<formulaire_cfp> formulaire_cfp { get; set; }
        public virtual DbSet<formulaire_cda> formulaire_cda { get; set; }
        public virtual DbSet<formulaire_ecv> formulaire_ecv { get; set; }
        public virtual DbSet<formulaire_seo> formulaire_seo { get; set; }
        public virtual DbSet<formulaire_sfa> formulaire_sfa { get; set; }
    }
}

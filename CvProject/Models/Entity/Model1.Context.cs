﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CvProject.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCvEntities1 : DbContext
    {
        public DbCvEntities1()
            : base("name=DbCvEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Award> Award { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Interest> Interest { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<SocialMedia> SocialMedia { get; set; }
    }
}

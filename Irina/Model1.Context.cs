﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Irina
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BalkiaEntities1 : DbContext
    {
        public BalkiaEntities1()
            : base("name=BalkiaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Participants> Participants { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectsTeams> ProjectsTeams { get; set; }
        public virtual DbSet<Time> Time { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
using dinamica.erp.wcf.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dinamica.erp.wcf
{
    public class ERPContext : DbContext
    {
        public ERPContext() : base("Name=PruebaDB")
        {
            Database.SetInitializer<ERPContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var clients = modelBuilder.Entity<Client>().HasKey(u => u.Id).ToTable("Clientes");
        }

        public virtual DbSet<Client> ClientsDao { get; set; }
    }
}
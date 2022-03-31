using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Warehouse_managment
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Kind> Kinds { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Warehouses)
                .WithOptional(e => e.Client)
                .HasForeignKey(e => e.Clients_ClientID);

            modelBuilder.Entity<Kind>()
                .HasMany(e => e.Warehouses)
                .WithMany(e => e.Kinds)
                .Map(m => m.ToTable("KindsWarehouses").MapLeftKey("Kinds_KindID").MapRightKey("Warehouses_WarehouseID"));

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Warehouses)
                .WithOptional(e => e.Supplier)
                .HasForeignKey(e => e.Suppliers_SupplierID);
        }
    }
}

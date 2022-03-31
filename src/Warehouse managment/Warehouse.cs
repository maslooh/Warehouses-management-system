namespace Warehouse_managment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouse()
        {
            Kinds = new HashSet<Kind>();
        }

        public int WarehouseID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string ManagerName { get; set; }

        public int? Clients_ClientID { get; set; }

        public int? Suppliers_SupplierID { get; set; }

        public virtual Client Client { get; set; }

        public virtual Supplier Supplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kind> Kinds { get; set; }
    }
}

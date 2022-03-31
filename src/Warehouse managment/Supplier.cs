namespace Warehouse_managment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            Warehouses = new HashSet<Warehouse>();
        }

        public int SupplierID { get; set; }

        public string Name { get; set; }

        public int Telephone { get; set; }

        public int Fax { get; set; }

        public int Mobile { get; set; }

        public string Email { get; set; }

        public string Site { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}

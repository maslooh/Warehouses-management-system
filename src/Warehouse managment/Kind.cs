namespace Warehouse_managment
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Kind
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kind()
        {
            Warehouses = new HashSet<Warehouse>();
        }

        public int KindID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string code { get; set; }

        public DateTime expirationDate { get; set; }

        public DateTime entranceDate { get; set; }

        public string Measurments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}

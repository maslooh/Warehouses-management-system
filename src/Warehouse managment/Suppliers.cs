using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_managment
{
    public class Suppliers
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public int Telephone { get; set; }
        public int Fax { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public List<Kinds> Kinds { get; set; }
        public List<Warehouses> Warehouses { get; set; }
    }
}

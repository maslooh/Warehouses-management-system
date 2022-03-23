using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_managment
{
    public class Warehouses
    {
        public int WarehouseID { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string ManagerName { set; get; }
        public List<Kinds> Kinds { set; get; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_managment
{
    public class Kinds
    {
        public int KindID { get; set; }
        public string Name { get; set; }
        public List<string> Measurments { get; set; }
    }
}

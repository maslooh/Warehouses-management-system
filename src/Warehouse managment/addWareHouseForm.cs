using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_managment
{
    public partial class addWareHouseForm : Form
    {
        public addWareHouseForm()
        {
            InitializeComponent();
        }

        private void btnCancelWh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddWh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addWareHouseForm_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addWareHouseForm f = new addWareHouseForm();
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateWh u =new updateWh();
            u.ShowDialog();
        }

        private void kindsBtn_Click(object sender, EventArgs e)
        {
            kindsForm kf = new kindsForm();
            kf.ShowDialog();
            
        }
    }
}

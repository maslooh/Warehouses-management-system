using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_managment.kinds;

namespace Warehouse_managment
{
    public partial class Form1 : Form
    {
        Model1 model;
        public Form1()
        {
            InitializeComponent();
            model= new Model1();
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

        private void btnKindAdd_Click(object sender, EventArgs e)
        {
            AddKind ak = new AddKind();
            ak.ShowDialog();
        }

        private void btnKindUpdate_Click(object sender, EventArgs e)
        {
            UpdateKind uk = new UpdateKind();
            uk.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            Model1 model1 = new Model1();
            warehouseList.DataSource = model1.Warehouses.Select(c => c).ToList();
            kindsList.DataSource = model1.Kinds.Select(c => c).ToList();
        }
    }
}

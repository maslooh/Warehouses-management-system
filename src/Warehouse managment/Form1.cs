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
using Warehouse_managment.supplieres;
using Warehouse_managment.clients;

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
            // TODO: This line of code loads data into the 'warehouse_managment_DBDataSet2.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter1.Fill(this.warehouse_managment_DBDataSet2.Clients);
            // TODO: This line of code loads data into the 'warehouse_managment_DB_CLientsList.Clients' table. You can move, or remove it, as needed.
            loadData();
        }
        public void loadData()
        {
            Model1 model1 = new Model1();
            warehouseList.DataSource = model1.Warehouses.Select(c => c).ToList();
            kindsList.DataSource = model1.Kinds.Select(c => c).ToList();
            listsup.DataSource=model1.Suppliers.Select(c => c).ToList();
            listClients.DataSource = model1.Clients.Select(c => c).ToList();
        }

       

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            addSup add = new addSup();
            add.Show();
        }

        private void btnUpdateSup_Click(object sender, EventArgs e)
        {
            updateSup update = new updateSup();
            update.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addClient add = new addClient();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateClient update = new updateClient();
            update.Show();

        }
    }
}

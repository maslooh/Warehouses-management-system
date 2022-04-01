using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_managment.kinds
{
    public partial class UpdateKind : Form
    {
        Model1 model=new Model1();
  
        public UpdateKind()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateKind_Load(object sender, EventArgs e)
        {
            comboWarehouseChoose.DataSource = model.Warehouses.Select(c => c.Name).ToList();
        }

        private void comboWarehouseChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            Warehouse warehouse = model.Warehouses.SingleOrDefault(c => c.Name == comboWarehouseChoose.Text);
            if (warehouse != null)
            {
                comboChoseKind.DataSource = model.Warehouses.Where(c => c.WarehouseID==warehouse.WarehouseID).SelectMany(c=>c.Kinds).Select(c=>c.Name).ToList();
            }
            else
            {
                comboChoseKind.DataSource = null;
            }
                
        }

        void loadKinds()
        {
            Warehouse warehouse = model.Warehouses.SingleOrDefault(c => c.Name == comboWarehouseChoose.Text);
            comboChoseKind.DataSource = model.Warehouses.Where(c => c.WarehouseID == warehouse.WarehouseID).SelectMany(c => c.Kinds).Select(c => c.Name).ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Kind myKind = model.Warehouses.SingleOrDefault(w => w.Name == comboWarehouseChoose.Text).Kinds.SingleOrDefault(k => k.Name == comboChoseKind.Text);
            if (myKind != null)
            {
                myKind.Name = txtKindName.Text;
                myKind.code = txtkindCode.Text;
                myKind.entranceDate = entranceDate.Value;
                myKind.expirationDate = expirationDate.Value;
                myKind.Measurments = measurement.Text;
                model.SaveChanges();
                loadKinds();
                Form1 form = (Form1)Application.OpenForms["Form1"];
                form.loadData();
                this.Close();
            }
            else
                MessageBox.Show("خطأ");
           
        }
    }
}

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
    public partial class updateWh : Form
    {
        private Model1 model;
        public updateWh()
        {
            InitializeComponent();
            model= new Model1();
        }

        private void btnCancelWh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddWh_Click(object sender, EventArgs e)
        {
            
                if (boxWhName.Text != "")
                {
                    Warehouse warehouse = model.Warehouses.SingleOrDefault(item => item.Name == listWh.Text);
                    if (warehouse != null)
                    {
                        warehouse.Name = boxWhName.Text;
                        warehouse.Address = boxWhAddress.Text;
                        warehouse.ManagerName = boxMangerName.Text;
                        model.SaveChanges();
                        listWh.DataSource = model.Warehouses.Select(c => c.Name).ToList();
                        Form1 form = (Form1)Application.OpenForms["Form1"];
                        form.loadData();
                        this.Close();
                    }
                    else
                        MessageBox.Show("خطأ");
                }
                else
                    MessageBox.Show("إختر مخزن قبل التعديل");
            
        }

        private void updateWh_Load(object sender, EventArgs e)
        {
            listWh.DataSource = model.Warehouses.Select(c => c.Name).ToList();
           
        }

        private void listWh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Warehouse warehouse = model.Warehouses.SingleOrDefault(item=>item.Name== listWh.Text);
            boxWhName.Text = warehouse.Name;
            boxMangerName.Text = warehouse.ManagerName;
            boxWhAddress.Text = warehouse.Address;
            
        }
    }
}

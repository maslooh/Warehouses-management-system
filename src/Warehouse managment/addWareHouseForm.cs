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
        Model1 model;
        public addWareHouseForm()
        {
            InitializeComponent();
            model = new Model1();
        }

        private void btnCancelWh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddWh_Click(object sender, EventArgs e)
        {
            Warehouse warehose = new Warehouse();
            try
            {
                if (boxWhName.Text != string.Empty&
                    boxWhAddress.Text != string.Empty&
                    boxWhAdmin.Text!= string.Empty)
                {
                    warehose.Address=boxWhAddress.Text;
                    warehose.Name = boxWhName.Text;
                    warehose.ManagerName = boxWhAdmin.Text;
                    model.Warehouses.Add(warehose);
                    model.SaveChanges();
                    Form1 form = (Form1)Application.OpenForms["Form1"];
                    form.loadData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ادخل جميع القيم المطلوبة");
                }
            }
            catch
            {
                MessageBox.Show("خطأ");
            }
            
        }

        private void addWareHouseForm_Load(object sender, EventArgs e)
        {

        }
    }
}

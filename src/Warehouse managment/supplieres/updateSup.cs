using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_managment.supplieres
{
    public partial class updateSup : Form
    {
        Model1 model = new Model1();
        public updateSup()
        {
            InitializeComponent();
        }

        private void uodateSup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse_managment_DBDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.warehouse_managment_DBDataSet.Suppliers);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Supplier sup = model.Suppliers.Find(int.Parse(comboSup.SelectedValue.ToString()));
            if (sup != null)
            {
                sup.Name = txtName.Text==""?sup.Name: txtName.Text;
                sup.Email = txtMail.Text == "" ? sup.Email : txtMail.Text;
                sup.Fax = txtFax.Text == "" ? sup.Fax : txtFax.Text;
                sup.Site = txtSite.Text == "" ? sup.Site : txtSite.Text;
                sup.Mobile = txtMobile.Text == "" ? sup.Mobile : txtMobile.Text;
                sup.Telephone = txtPhone.Text == "" ? sup.Telephone : txtPhone.Text;

                model.SaveChanges();
                Form1 form = (Form1)Application.OpenForms["Form1"];
                form.loadData();
                this.Close();
            }
            else
                MessageBox.Show("خطأ");
            
        }
    }
}

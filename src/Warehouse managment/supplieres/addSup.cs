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
    public partial class addSup : Form
    {
        Model1 model = new Model1();
        public addSup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier newsup = new Supplier();
            newsup.Name = txtName.Text;
            newsup.Email = txtMail.Text;
            newsup.Fax = txtFax.Text;
            newsup.Site = txtSite.Text;
            newsup.Mobile=txtMobile.Text;
            newsup.Telephone = txtPhone.Text;

            model.Suppliers.Add(newsup);
            model.SaveChanges();
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.loadData();
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_managment.clients
{
 
    public partial class addClient : Form
    {
        Model1 model = new Model1();
        public addClient()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Client newClient = new Client();
            newClient.Name = txtName.Text;
            newClient.Email = txtMail.Text;
            newClient.Fax = txtFax.Text;
            newClient.Site = txtSite.Text;
            newClient.Mobile = txtMobile.Text;
            newClient.Telephone = txtPhone.Text;

            model.Clients.Add(newClient);
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

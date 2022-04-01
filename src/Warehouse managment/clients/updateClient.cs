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
    public partial class updateClient : Form
    {
        Model1 model = new Model1();
        public updateClient()
        {
            InitializeComponent();
        }

        private void updateClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouse_managment_DBDataSet1.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.warehouse_managment_DBDataSet1.Clients);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Client client = model.Clients.Find(int.Parse(comboClient.SelectedValue.ToString()));
            if (client != null)
            {
                client.Name = txtName.Text == "" ?client.Name : txtName.Text;
                client.Email = txtMail.Text == "" ? client.Email : txtMail.Text;
                client.Fax = txtFax.Text == "" ? client.Fax : txtFax.Text;
                client.Site = txtSite.Text == "" ? client.Site : txtSite.Text;
                client.Mobile = txtMobile.Text == "" ? client.Mobile : txtMobile.Text;
                client.Telephone = txtPhone.Text == "" ? client.Telephone : txtPhone.Text;

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

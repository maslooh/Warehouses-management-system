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
    public partial class AddKind : Form
    {
        public Model1 model =new Model1();
        public AddKind()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Kind kind = new Kind();
            try
            {
                if (txtKindName.Text != string.Empty &
                    txtkindCode.Text != string.Empty &
                    txtMeasurement.Text != string.Empty&
                    comboChoseKind.Text != string.Empty &
                    expirationDate.Text != string.Empty &
                    entranceDate.Text != string.Empty )
                {
                    Warehouse warehouse = model.Warehouses.SingleOrDefault(c => c.Name == comboChoseKind.Text);
                    if(warehouse != null)
                    {
                        kind.Name = txtKindName.Text;
                        kind.code = txtkindCode.Text;
                        kind.Measurments = txtMeasurement.Text;
                        kind.expirationDate = expirationDate.Value;
                        kind.entranceDate = entranceDate.Value;
                        kind.Warehouses.Add(warehouse);
                        model.Kinds.Add(kind);
                        model.SaveChanges();
                        Form1 form = (Form1)Application.OpenForms["Form1"];
                        form.loadData();
                        this.Close();
                    }
                    
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

        private void AddKind_Load(object sender, EventArgs e)
        {
            comboChoseKind.DataSource = model.Warehouses.Select(c => c.Name).ToList();
        }
    }
}

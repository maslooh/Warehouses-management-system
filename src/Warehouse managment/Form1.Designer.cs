
namespace Warehouse_managment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.warehouseList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.wareHousePage = new System.Windows.Forms.TabPage();
            this.kindsPage = new System.Windows.Forms.TabPage();
            this.btnKindUpdate = new System.Windows.Forms.Button();
            this.btnKindAdd = new System.Windows.Forms.Button();
            this.kindsList = new System.Windows.Forms.DataGridView();
            this.supplierPage = new System.Windows.Forms.TabPage();
            this.btnUpdateSup = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.listsup = new System.Windows.Forms.DataGridView();
            this.clientsPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listClients = new System.Windows.Forms.DataGridView();
            this.supplyPerPage = new System.Windows.Forms.TabPage();
            this.sellPerPage = new System.Windows.Forms.TabPage();
            this.transeferPage = new System.Windows.Forms.TabPage();
            this.reportsPage = new System.Windows.Forms.TabPage();
            this.warehouse_managment_DBDataSet1 = new Warehouse_managment.Warehouse_managment_DBDataSet1();
            this.warehousemanagmentDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Warehouse_managment.Warehouse_managment_DB_CLientsListTableAdapters.ClientsTableAdapter();
            this.warehouse_managment_DBDataSet2 = new Warehouse_managment.Warehouse_managment_DBDataSet2();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter1 = new Warehouse_managment.Warehouse_managment_DBDataSet2TableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.wareHousePage.SuspendLayout();
            this.kindsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kindsList)).BeginInit();
            this.supplierPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listsup)).BeginInit();
            this.clientsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_managment_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousemanagmentDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_managment_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // warehouseList
            // 
            this.warehouseList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.warehouseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehouseList.Location = new System.Drawing.Point(8, 66);
            this.warehouseList.Name = "warehouseList";
            this.warehouseList.Size = new System.Drawing.Size(776, 348);
            this.warehouseList.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "اضافة مخزن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(134, 17);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 31);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "تعديل مخزن";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.wareHousePage);
            this.tabControl1.Controls.Add(this.kindsPage);
            this.tabControl1.Controls.Add(this.supplierPage);
            this.tabControl1.Controls.Add(this.clientsPage);
            this.tabControl1.Controls.Add(this.supplyPerPage);
            this.tabControl1.Controls.Add(this.sellPerPage);
            this.tabControl1.Controls.Add(this.transeferPage);
            this.tabControl1.Controls.Add(this.reportsPage);
            this.tabControl1.Location = new System.Drawing.Point(-4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 450);
            this.tabControl1.TabIndex = 5;
            // 
            // wareHousePage
            // 
            this.wareHousePage.Controls.Add(this.warehouseList);
            this.wareHousePage.Controls.Add(this.btnUpdate);
            this.wareHousePage.Controls.Add(this.btnAdd);
            this.wareHousePage.Location = new System.Drawing.Point(4, 22);
            this.wareHousePage.Name = "wareHousePage";
            this.wareHousePage.Padding = new System.Windows.Forms.Padding(3);
            this.wareHousePage.Size = new System.Drawing.Size(796, 424);
            this.wareHousePage.TabIndex = 0;
            this.wareHousePage.Text = "إدارة المخازن";
            this.wareHousePage.UseVisualStyleBackColor = true;
            // 
            // kindsPage
            // 
            this.kindsPage.Controls.Add(this.btnKindUpdate);
            this.kindsPage.Controls.Add(this.btnKindAdd);
            this.kindsPage.Controls.Add(this.kindsList);
            this.kindsPage.Location = new System.Drawing.Point(4, 22);
            this.kindsPage.Name = "kindsPage";
            this.kindsPage.Padding = new System.Windows.Forms.Padding(3);
            this.kindsPage.Size = new System.Drawing.Size(796, 424);
            this.kindsPage.TabIndex = 1;
            this.kindsPage.Text = "إدارة الاصناف";
            this.kindsPage.UseVisualStyleBackColor = true;
            // 
            // btnKindUpdate
            // 
            this.btnKindUpdate.Location = new System.Drawing.Point(133, 17);
            this.btnKindUpdate.Name = "btnKindUpdate";
            this.btnKindUpdate.Size = new System.Drawing.Size(103, 31);
            this.btnKindUpdate.TabIndex = 10;
            this.btnKindUpdate.Text = "تعديل صنف";
            this.btnKindUpdate.UseVisualStyleBackColor = true;
            this.btnKindUpdate.Click += new System.EventHandler(this.btnKindUpdate_Click);
            // 
            // btnKindAdd
            // 
            this.btnKindAdd.Location = new System.Drawing.Point(10, 17);
            this.btnKindAdd.Name = "btnKindAdd";
            this.btnKindAdd.Size = new System.Drawing.Size(103, 31);
            this.btnKindAdd.TabIndex = 9;
            this.btnKindAdd.Text = "اضافة صنف";
            this.btnKindAdd.UseVisualStyleBackColor = true;
            this.btnKindAdd.Click += new System.EventHandler(this.btnKindAdd_Click);
            // 
            // kindsList
            // 
            this.kindsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kindsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kindsList.Location = new System.Drawing.Point(10, 65);
            this.kindsList.Name = "kindsList";
            this.kindsList.Size = new System.Drawing.Size(776, 342);
            this.kindsList.TabIndex = 8;
            // 
            // supplierPage
            // 
            this.supplierPage.Controls.Add(this.btnUpdateSup);
            this.supplierPage.Controls.Add(this.btnAddSup);
            this.supplierPage.Controls.Add(this.listsup);
            this.supplierPage.Location = new System.Drawing.Point(4, 22);
            this.supplierPage.Name = "supplierPage";
            this.supplierPage.Size = new System.Drawing.Size(796, 424);
            this.supplierPage.TabIndex = 2;
            this.supplierPage.Text = "إدارة الموردين";
            this.supplierPage.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSup
            // 
            this.btnUpdateSup.Location = new System.Drawing.Point(133, 17);
            this.btnUpdateSup.Name = "btnUpdateSup";
            this.btnUpdateSup.Size = new System.Drawing.Size(103, 31);
            this.btnUpdateSup.TabIndex = 13;
            this.btnUpdateSup.Text = "تعديل مورد";
            this.btnUpdateSup.UseVisualStyleBackColor = true;
            this.btnUpdateSup.Click += new System.EventHandler(this.btnUpdateSup_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.Location = new System.Drawing.Point(10, 17);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(103, 31);
            this.btnAddSup.TabIndex = 12;
            this.btnAddSup.Text = "اضافة مورد";
            this.btnAddSup.UseVisualStyleBackColor = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // listsup
            // 
            this.listsup.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listsup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listsup.Location = new System.Drawing.Point(10, 65);
            this.listsup.Name = "listsup";
            this.listsup.Size = new System.Drawing.Size(776, 342);
            this.listsup.TabIndex = 11;
            // 
            // clientsPage
            // 
            this.clientsPage.Controls.Add(this.button3);
            this.clientsPage.Controls.Add(this.button4);
            this.clientsPage.Controls.Add(this.listClients);
            this.clientsPage.Location = new System.Drawing.Point(4, 22);
            this.clientsPage.Name = "clientsPage";
            this.clientsPage.Size = new System.Drawing.Size(796, 424);
            this.clientsPage.TabIndex = 3;
            this.clientsPage.Text = "إدارة العملاء";
            this.clientsPage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 31);
            this.button3.TabIndex = 13;
            this.button3.Text = "تعديل عميل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 31);
            this.button4.TabIndex = 12;
            this.button4.Text = "اضافة عميل";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listClients
            // 
            this.listClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listClients.Location = new System.Drawing.Point(10, 65);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(776, 342);
            this.listClients.TabIndex = 11;
            // 
            // supplyPerPage
            // 
            this.supplyPerPage.Location = new System.Drawing.Point(4, 22);
            this.supplyPerPage.Name = "supplyPerPage";
            this.supplyPerPage.Size = new System.Drawing.Size(796, 424);
            this.supplyPerPage.TabIndex = 4;
            this.supplyPerPage.Text = "إذن توريد";
            this.supplyPerPage.UseVisualStyleBackColor = true;
            // 
            // sellPerPage
            // 
            this.sellPerPage.Location = new System.Drawing.Point(4, 22);
            this.sellPerPage.Name = "sellPerPage";
            this.sellPerPage.Size = new System.Drawing.Size(796, 424);
            this.sellPerPage.TabIndex = 5;
            this.sellPerPage.Text = "إذن صرف";
            this.sellPerPage.UseVisualStyleBackColor = true;
            // 
            // transeferPage
            // 
            this.transeferPage.Location = new System.Drawing.Point(4, 22);
            this.transeferPage.Name = "transeferPage";
            this.transeferPage.Size = new System.Drawing.Size(796, 424);
            this.transeferPage.TabIndex = 6;
            this.transeferPage.Text = "تحويل الاصناف";
            this.transeferPage.UseVisualStyleBackColor = true;
            // 
            // reportsPage
            // 
            this.reportsPage.Location = new System.Drawing.Point(4, 22);
            this.reportsPage.Name = "reportsPage";
            this.reportsPage.Size = new System.Drawing.Size(796, 424);
            this.reportsPage.TabIndex = 7;
            this.reportsPage.Text = "التقارير";
            this.reportsPage.UseVisualStyleBackColor = true;
            // 
            // warehouse_managment_DBDataSet1
            // 
            this.warehouse_managment_DBDataSet1.DataSetName = "Warehouse_managment_DBDataSet1";
            this.warehouse_managment_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // warehousemanagmentDBDataSet1BindingSource
            // 
            this.warehousemanagmentDBDataSet1BindingSource.DataSource = this.warehouse_managment_DBDataSet1;
            this.warehousemanagmentDBDataSet1BindingSource.Position = 0;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // warehouse_managment_DBDataSet2
            // 
            this.warehouse_managment_DBDataSet2.DataSetName = "Warehouse_managment_DBDataSet2";
            this.warehouse_managment_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.warehouse_managment_DBDataSet2;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.wareHousePage.ResumeLayout(false);
            this.kindsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kindsList)).EndInit();
            this.supplierPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listsup)).EndInit();
            this.clientsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_managment_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousemanagmentDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_managment_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView warehouseList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage wareHousePage;
        private System.Windows.Forms.TabPage kindsPage;
        private System.Windows.Forms.Button btnKindUpdate;
        private System.Windows.Forms.Button btnKindAdd;
        private System.Windows.Forms.DataGridView kindsList;
        private System.Windows.Forms.TabPage supplierPage;
        private System.Windows.Forms.Button btnUpdateSup;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.DataGridView listsup;
        private System.Windows.Forms.TabPage clientsPage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView listClients;
        private System.Windows.Forms.TabPage supplyPerPage;
        private System.Windows.Forms.TabPage sellPerPage;
        private System.Windows.Forms.TabPage transeferPage;
        private System.Windows.Forms.TabPage reportsPage;
        private System.Windows.Forms.BindingSource warehousemanagmentDBDataSet1BindingSource;
        private Warehouse_managment_DBDataSet1 warehouse_managment_DBDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Warehouse_managment_DB_CLientsListTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private Warehouse_managment_DBDataSet2 warehouse_managment_DBDataSet2;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private Warehouse_managment_DBDataSet2TableAdapters.ClientsTableAdapter clientsTableAdapter1;
    }
}


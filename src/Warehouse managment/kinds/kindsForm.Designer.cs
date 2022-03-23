namespace Warehouse_managment
{
    partial class kindsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kindsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kindsBtn = new System.Windows.Forms.ToolStripButton();
            this.btnSuppliers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnInvoce = new System.Windows.Forms.ToolStripButton();
            this.btnSupply = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kindsBtn,
            this.btnSuppliers,
            this.toolStripButton1,
            this.btnInvoce,
            this.btnSupply});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // kindsBtn
            // 
            this.kindsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.kindsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kindsBtn.Name = "kindsBtn";
            this.kindsBtn.Size = new System.Drawing.Size(52, 22);
            this.kindsBtn.Text = "الأصناف";
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("btnSuppliers.Image")));
            this.btnSuppliers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(53, 22);
            this.btnSuppliers.Text = "الموردين";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton1.Text = "العملاء";
            // 
            // btnInvoce
            // 
            this.btnInvoce.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInvoce.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoce.Image")));
            this.btnInvoce.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInvoce.Name = "btnInvoce";
            this.btnInvoce.Size = new System.Drawing.Size(58, 22);
            this.btnInvoce.Text = "إذن صرف";
            // 
            // btnSupply
            // 
            this.btnSupply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSupply.Image = ((System.Drawing.Image)(resources.GetObject("btnSupply.Image")));
            this.btnSupply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSupply.Name = "btnSupply";
            this.btnSupply.Size = new System.Drawing.Size(57, 22);
            this.btnSupply.Text = "إذن توريد";
            this.btnSupply.ToolTipText = "إذن توريد";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 54);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 31);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "تعديل صنف";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 31);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "اضافة صنف";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 342);
            this.dataGridView1.TabIndex = 5;
            // 
            // kindsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kindsForm";
            this.Text = "kindsForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton kindsBtn;
        private System.Windows.Forms.ToolStripButton btnSuppliers;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnInvoce;
        private System.Windows.Forms.ToolStripButton btnSupply;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
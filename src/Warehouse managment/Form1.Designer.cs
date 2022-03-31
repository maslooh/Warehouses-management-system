
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
            this.warehouseList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.wareHousePage = new System.Windows.Forms.TabPage();
            this.kindsPage = new System.Windows.Forms.TabPage();
            this.btnKindUpdate = new System.Windows.Forms.Button();
            this.btnKindAdd = new System.Windows.Forms.Button();
            this.kindsList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.wareHousePage.SuspendLayout();
            this.kindsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kindsList)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warehouseList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.wareHousePage.ResumeLayout(false);
            this.kindsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kindsList)).EndInit();
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
    }
}


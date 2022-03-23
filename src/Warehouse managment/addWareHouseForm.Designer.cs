namespace Warehouse_managment
{
    partial class addWareHouseForm
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
            this.boxWhName = new System.Windows.Forms.TextBox();
            this.boxWhAddress = new System.Windows.Forms.TextBox();
            this.boxWhAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddWh = new System.Windows.Forms.Button();
            this.btnCancelWh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxWhName
            // 
            this.boxWhName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxWhName.Location = new System.Drawing.Point(12, 48);
            this.boxWhName.Name = "boxWhName";
            this.boxWhName.Size = new System.Drawing.Size(372, 20);
            this.boxWhName.TabIndex = 0;
            // 
            // boxWhAddress
            // 
            this.boxWhAddress.Location = new System.Drawing.Point(12, 97);
            this.boxWhAddress.Name = "boxWhAddress";
            this.boxWhAddress.Size = new System.Drawing.Size(372, 20);
            this.boxWhAddress.TabIndex = 1;
            // 
            // boxWhAdmin
            // 
            this.boxWhAdmin.Location = new System.Drawing.Point(12, 148);
            this.boxWhAdmin.Name = "boxWhAdmin";
            this.boxWhAdmin.Size = new System.Drawing.Size(372, 20);
            this.boxWhAdmin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم المخزن";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "العنوان";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "اسم المسئول";
            // 
            // btnAddWh
            // 
            this.btnAddWh.Location = new System.Drawing.Point(41, 198);
            this.btnAddWh.Name = "btnAddWh";
            this.btnAddWh.Size = new System.Drawing.Size(141, 32);
            this.btnAddWh.TabIndex = 6;
            this.btnAddWh.Text = "إضافة";
            this.btnAddWh.UseVisualStyleBackColor = true;
            this.btnAddWh.Click += new System.EventHandler(this.btnAddWh_Click);
            // 
            // btnCancelWh
            // 
            this.btnCancelWh.Location = new System.Drawing.Point(206, 198);
            this.btnCancelWh.Name = "btnCancelWh";
            this.btnCancelWh.Size = new System.Drawing.Size(142, 32);
            this.btnCancelWh.TabIndex = 7;
            this.btnCancelWh.Text = "إلغاء";
            this.btnCancelWh.UseVisualStyleBackColor = true;
            this.btnCancelWh.Click += new System.EventHandler(this.btnCancelWh_Click);
            // 
            // addWareHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 252);
            this.Controls.Add(this.btnCancelWh);
            this.Controls.Add(this.btnAddWh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxWhAdmin);
            this.Controls.Add(this.boxWhAddress);
            this.Controls.Add(this.boxWhName);
            this.Name = "addWareHouseForm";
            this.Text = "addWareHouseForm";
            this.Load += new System.EventHandler(this.addWareHouseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxWhName;
        private System.Windows.Forms.TextBox boxWhAddress;
        private System.Windows.Forms.TextBox boxWhAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddWh;
        private System.Windows.Forms.Button btnCancelWh;
    }
}
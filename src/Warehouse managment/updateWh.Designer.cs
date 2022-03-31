namespace Warehouse_managment
{
    partial class updateWh
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
            this.btnCancelWh = new System.Windows.Forms.Button();
            this.btnAddWh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxWhName = new System.Windows.Forms.TextBox();
            this.listWh = new System.Windows.Forms.ComboBox();
            this.boxWhAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxMangerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelWh
            // 
            this.btnCancelWh.Location = new System.Drawing.Point(211, 195);
            this.btnCancelWh.Name = "btnCancelWh";
            this.btnCancelWh.Size = new System.Drawing.Size(142, 32);
            this.btnCancelWh.TabIndex = 15;
            this.btnCancelWh.Text = "إلغاء";
            this.btnCancelWh.UseVisualStyleBackColor = true;
            this.btnCancelWh.Click += new System.EventHandler(this.btnCancelWh_Click);
            // 
            // btnAddWh
            // 
            this.btnAddWh.Location = new System.Drawing.Point(46, 195);
            this.btnAddWh.Name = "btnAddWh";
            this.btnAddWh.Size = new System.Drawing.Size(141, 32);
            this.btnAddWh.TabIndex = 14;
            this.btnAddWh.Text = "تعديل";
            this.btnAddWh.UseVisualStyleBackColor = true;
            this.btnAddWh.Click += new System.EventHandler(this.btnAddWh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "اسم المخزن";
            // 
            // boxWhName
            // 
            this.boxWhName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxWhName.Location = new System.Drawing.Point(10, 61);
            this.boxWhName.Name = "boxWhName";
            this.boxWhName.Size = new System.Drawing.Size(372, 20);
            this.boxWhName.TabIndex = 8;
            // 
            // listWh
            // 
            this.listWh.DropDownHeight = 110;
            this.listWh.FormattingEnabled = true;
            this.listWh.IntegralHeight = false;
            this.listWh.Location = new System.Drawing.Point(12, 12);
            this.listWh.Name = "listWh";
            this.listWh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listWh.Size = new System.Drawing.Size(372, 21);
            this.listWh.TabIndex = 16;
            this.listWh.Text = "إختر المخزن";
            this.listWh.SelectedIndexChanged += new System.EventHandler(this.listWh_SelectedIndexChanged);
            // 
            // boxWhAddress
            // 
            this.boxWhAddress.Location = new System.Drawing.Point(12, 100);
            this.boxWhAddress.Name = "boxWhAddress";
            this.boxWhAddress.Size = new System.Drawing.Size(372, 20);
            this.boxWhAddress.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "العنوان";
            // 
            // boxMangerName
            // 
            this.boxMangerName.Location = new System.Drawing.Point(12, 153);
            this.boxMangerName.Name = "boxMangerName";
            this.boxMangerName.Size = new System.Drawing.Size(372, 20);
            this.boxMangerName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "اسم المسئول";
            // 
            // updateWh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 244);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxMangerName);
            this.Controls.Add(this.listWh);
            this.Controls.Add(this.btnCancelWh);
            this.Controls.Add(this.btnAddWh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxWhAddress);
            this.Controls.Add(this.boxWhName);
            this.Name = "updateWh";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.updateWh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelWh;
        private System.Windows.Forms.Button btnAddWh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxWhName;
        private System.Windows.Forms.ComboBox listWh;
        private System.Windows.Forms.TextBox boxWhAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxMangerName;
        private System.Windows.Forms.Label label4;
    }
}
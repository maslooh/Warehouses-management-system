namespace Warehouse_managment.kinds
{
    partial class AddKind
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
            this.entranceDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.expirationDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMeasurement = new System.Windows.Forms.TextBox();
            this.comboChoseKind = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtkindCode = new System.Windows.Forms.TextBox();
            this.txtKindName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // entranceDate
            // 
            this.entranceDate.Location = new System.Drawing.Point(8, 218);
            this.entranceDate.Name = "entranceDate";
            this.entranceDate.Size = new System.Drawing.Size(371, 20);
            this.entranceDate.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "تاريخ الإدراج";
            // 
            // expirationDate
            // 
            this.expirationDate.Location = new System.Drawing.Point(8, 161);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(373, 20);
            this.expirationDate.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "وحدة القياس";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "تاريخ الصلاحية";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "كود الصنف";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "اسم الصنف";
            // 
            // txtMeasurement
            // 
            this.txtMeasurement.Location = new System.Drawing.Point(8, 268);
            this.txtMeasurement.Name = "txtMeasurement";
            this.txtMeasurement.Size = new System.Drawing.Size(371, 20);
            this.txtMeasurement.TabIndex = 47;
            // 
            // comboChoseKind
            // 
            this.comboChoseKind.DropDownHeight = 110;
            this.comboChoseKind.FormattingEnabled = true;
            this.comboChoseKind.IntegralHeight = false;
            this.comboChoseKind.Location = new System.Drawing.Point(8, 12);
            this.comboChoseKind.Name = "comboChoseKind";
            this.comboChoseKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboChoseKind.Size = new System.Drawing.Size(376, 21);
            this.comboChoseKind.TabIndex = 46;
            this.comboChoseKind.Text = "إختر المخزن";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 32);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(47, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 32);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "إضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtkindCode
            // 
            this.txtkindCode.Location = new System.Drawing.Point(8, 110);
            this.txtkindCode.Name = "txtkindCode";
            this.txtkindCode.Size = new System.Drawing.Size(374, 20);
            this.txtkindCode.TabIndex = 43;
            // 
            // txtKindName
            // 
            this.txtKindName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKindName.Location = new System.Drawing.Point(8, 61);
            this.txtKindName.Name = "txtKindName";
            this.txtKindName.Size = new System.Drawing.Size(374, 20);
            this.txtKindName.TabIndex = 42;
            // 
            // AddKind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 361);
            this.Controls.Add(this.entranceDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expirationDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMeasurement);
            this.Controls.Add(this.comboChoseKind);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtkindCode);
            this.Controls.Add(this.txtKindName);
            this.Name = "AddKind";
            this.Text = "AddKind";
            this.Load += new System.EventHandler(this.AddKind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker entranceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker expirationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMeasurement;
        private System.Windows.Forms.ComboBox comboChoseKind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtkindCode;
        private System.Windows.Forms.TextBox txtKindName;
    }
}
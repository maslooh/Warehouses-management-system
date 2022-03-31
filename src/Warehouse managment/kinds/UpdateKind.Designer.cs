namespace Warehouse_managment.kinds
{
    partial class UpdateKind
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
            this.measurement = new System.Windows.Forms.TextBox();
            this.comboChoseKind = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtkindCode = new System.Windows.Forms.TextBox();
            this.txtKindName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.expirationDate = new System.Windows.Forms.DateTimePicker();
            this.entranceDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboWarehouseChoose = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // measurement
            // 
            this.measurement.Location = new System.Drawing.Point(10, 268);
            this.measurement.Name = "measurement";
            this.measurement.Size = new System.Drawing.Size(374, 20);
            this.measurement.TabIndex = 34;
            // 
            // comboChoseKind
            // 
            this.comboChoseKind.DropDownHeight = 110;
            this.comboChoseKind.FormattingEnabled = true;
            this.comboChoseKind.IntegralHeight = false;
            this.comboChoseKind.Location = new System.Drawing.Point(10, 12);
            this.comboChoseKind.Name = "comboChoseKind";
            this.comboChoseKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboChoseKind.Size = new System.Drawing.Size(178, 21);
            this.comboChoseKind.TabIndex = 33;
            this.comboChoseKind.Text = "إختر الصنف";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 32);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(47, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 32);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtkindCode
            // 
            this.txtkindCode.Location = new System.Drawing.Point(10, 110);
            this.txtkindCode.Name = "txtkindCode";
            this.txtkindCode.Size = new System.Drawing.Size(374, 20);
            this.txtkindCode.TabIndex = 29;
            // 
            // txtKindName
            // 
            this.txtKindName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKindName.Location = new System.Drawing.Point(10, 61);
            this.txtKindName.Name = "txtKindName";
            this.txtKindName.Size = new System.Drawing.Size(374, 20);
            this.txtKindName.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "وحدة القياس";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "تاريخ الصلاحية";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "كود الصنف";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "اسم الصنف";
            // 
            // expirationDate
            // 
            this.expirationDate.Location = new System.Drawing.Point(10, 161);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(374, 20);
            this.expirationDate.TabIndex = 39;
            // 
            // entranceDate
            // 
            this.entranceDate.Location = new System.Drawing.Point(10, 218);
            this.entranceDate.Name = "entranceDate";
            this.entranceDate.Size = new System.Drawing.Size(374, 20);
            this.entranceDate.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "تاريخ الإدراج";
            // 
            // comboWarehouseChoose
            // 
            this.comboWarehouseChoose.DropDownHeight = 110;
            this.comboWarehouseChoose.FormattingEnabled = true;
            this.comboWarehouseChoose.IntegralHeight = false;
            this.comboWarehouseChoose.Location = new System.Drawing.Point(194, 12);
            this.comboWarehouseChoose.Name = "comboWarehouseChoose";
            this.comboWarehouseChoose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboWarehouseChoose.Size = new System.Drawing.Size(190, 21);
            this.comboWarehouseChoose.TabIndex = 42;
            this.comboWarehouseChoose.Text = "إختر المخزن";
            this.comboWarehouseChoose.SelectedIndexChanged += new System.EventHandler(this.comboWarehouseChoose_SelectedIndexChanged);
            // 
            // UpdateKind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 359);
            this.Controls.Add(this.comboWarehouseChoose);
            this.Controls.Add(this.entranceDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expirationDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.measurement);
            this.Controls.Add(this.comboChoseKind);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtkindCode);
            this.Controls.Add(this.txtKindName);
            this.Name = "UpdateKind";
            this.Text = "UpdateKind";
            this.Load += new System.EventHandler(this.UpdateKind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox measurement;
        private System.Windows.Forms.ComboBox comboChoseKind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtkindCode;
        private System.Windows.Forms.TextBox txtKindName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker expirationDate;
        private System.Windows.Forms.DateTimePicker entranceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboWarehouseChoose;
    }
}
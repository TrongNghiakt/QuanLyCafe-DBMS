﻿namespace QuanLyCafe.VIEW
{
    partial class XuatHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XuatHD));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtgCustomerList = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.txtideployee = new System.Windows.Forms.TextBox();
            this.txtidbill = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomerList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox6);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnfind);
            this.guna2CustomGradientPanel1.Controls.Add(this.label6);
            this.guna2CustomGradientPanel1.Controls.Add(this.textBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtgCustomerList);
            this.guna2CustomGradientPanel1.Controls.Add(this.groupBox1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.AntiqueWhite;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.AntiqueWhite;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.AntiqueWhite;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.AntiqueWhite;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(44, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(785, 416);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QuanLyCafe.Properties.Resources.pngegg;
            this.pictureBox6.Location = new System.Drawing.Point(651, 29);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(29, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(695, 24);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 29);
            this.btnfind.TabIndex = 39;
            this.btnfind.Text = "Tìm kiếm";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Số điện thoại khách hàng:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(501, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 37;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtgCustomerList
            // 
            this.dtgCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.DiaChiKH,
            this.SdtKH});
            this.dtgCustomerList.Location = new System.Drawing.Point(460, 76);
            this.dtgCustomerList.Margin = new System.Windows.Forms.Padding(2);
            this.dtgCustomerList.Name = "dtgCustomerList";
            this.dtgCustomerList.ReadOnly = true;
            this.dtgCustomerList.RowHeadersWidth = 62;
            this.dtgCustomerList.RowTemplate.Height = 28;
            this.dtgCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCustomerList.Size = new System.Drawing.Size(325, 324);
            this.dtgCustomerList.TabIndex = 36;
            this.dtgCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomerList_CellContentClick);
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "nameCustomer";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.MinimumWidth = 8;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            this.TenKH.Width = 150;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.DataPropertyName = "Caddress";
            this.DiaChiKH.HeaderText = "Địa chỉ";
            this.DiaChiKH.MinimumWidth = 8;
            this.DiaChiKH.Name = "DiaChiKH";
            this.DiaChiKH.ReadOnly = true;
            this.DiaChiKH.Width = 150;
            // 
            // SdtKH
            // 
            this.SdtKH.DataPropertyName = "phoneNumber";
            this.SdtKH.HeaderText = "SĐT";
            this.SdtKH.MinimumWidth = 8;
            this.SdtKH.Name = "SdtKH";
            this.SdtKH.ReadOnly = true;
            this.SdtKH.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.txtphonenumber);
            this.groupBox1.Controls.Add(this.txtideployee);
            this.groupBox1.Controls.Add(this.txtidbill);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(303, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 40;
            this.button1.Text = "Xuất hóa đơn ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày lập bill";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số điện thoại khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Idbill:";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(231, 170);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(179, 26);
            this.txtdate.TabIndex = 4;
            this.txtdate.TextChanged += new System.EventHandler(this.txtdate_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(231, 135);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(179, 26);
            this.txtprice.TabIndex = 3;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(231, 99);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(179, 26);
            this.txtphonenumber.TabIndex = 1;
            // 
            // txtideployee
            // 
            this.txtideployee.Location = new System.Drawing.Point(231, 63);
            this.txtideployee.Name = "txtideployee";
            this.txtideployee.ReadOnly = true;
            this.txtideployee.Size = new System.Drawing.Size(179, 26);
            this.txtideployee.TabIndex = 2;
            this.txtideployee.TextChanged += new System.EventHandler(this.txtideployee_TextChanged);
            // 
            // txtidbill
            // 
            this.txtidbill.Location = new System.Drawing.Point(231, 26);
            this.txtidbill.Name = "txtidbill";
            this.txtidbill.ReadOnly = true;
            this.txtidbill.Size = new System.Drawing.Size(179, 26);
            this.txtidbill.TabIndex = 11;
            this.txtidbill.TextChanged += new System.EventHandler(this.txtidbill_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(834, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // XuatHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XuatHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XuatHD";
            this.Load += new System.EventHandler(this.XuatHD_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomerList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtideployee;
        private System.Windows.Forms.TextBox txtidbill;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgCustomerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtKH;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
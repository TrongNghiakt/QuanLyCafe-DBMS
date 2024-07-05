namespace QuanLyCafe.VIEW.UC
{
    partial class Bill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtide = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtidbill = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.SLMon,
            this.GiaMon,
            this.Date,
            this.phone,
            this.Address,
            this.Name});
            this.dataGridView1.Location = new System.Drawing.Point(275, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(409, 364);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.OldLace;
            this.txtaddress.Location = new System.Drawing.Point(106, 343);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(143, 20);
            this.txtaddress.TabIndex = 12;
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.Color.OldLace;
            this.txtsdt.Location = new System.Drawing.Point(106, 301);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(2);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.ReadOnly = true;
            this.txtsdt.Size = new System.Drawing.Size(143, 20);
            this.txtsdt.TabIndex = 11;
            // 
            // txtcustomer
            // 
            this.txtcustomer.BackColor = System.Drawing.Color.OldLace;
            this.txtcustomer.Location = new System.Drawing.Point(106, 253);
            this.txtcustomer.Margin = new System.Windows.Forms.Padding(2);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.ReadOnly = true;
            this.txtcustomer.Size = new System.Drawing.Size(143, 20);
            this.txtcustomer.TabIndex = 10;
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.OldLace;
            this.txtdate.Location = new System.Drawing.Point(106, 211);
            this.txtdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(143, 20);
            this.txtdate.TabIndex = 9;
            // 
            // txtide
            // 
            this.txtide.BackColor = System.Drawing.Color.OldLace;
            this.txtide.Location = new System.Drawing.Point(106, 137);
            this.txtide.Margin = new System.Windows.Forms.Padding(2);
            this.txtide.Name = "txtide";
            this.txtide.ReadOnly = true;
            this.txtide.Size = new System.Drawing.Size(143, 20);
            this.txtide.TabIndex = 8;
            this.txtide.TextChanged += new System.EventHandler(this.txtide_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(30, 345);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 18);
            this.label22.TabIndex = 7;
            this.label22.Text = "Địa chỉ:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(36, 303);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 18);
            this.label21.TabIndex = 6;
            this.label21.Text = "SĐT:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(11, 255);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 18);
            this.label20.TabIndex = 5;
            this.label20.Text = "Khách hàng";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(30, 213);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 18);
            this.label19.TabIndex = 4;
            this.label19.Text = "Ngày:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(2, 139);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 18);
            this.label18.TabIndex = 3;
            this.label18.Text = "ID Employee: ";
            // 
            // txtidbill
            // 
            this.txtidbill.BackColor = System.Drawing.Color.OldLace;
            this.txtidbill.Location = new System.Drawing.Point(106, 95);
            this.txtidbill.Margin = new System.Windows.Forms.Padding(2);
            this.txtidbill.Name = "txtidbill";
            this.txtidbill.ReadOnly = true;
            this.txtidbill.Size = new System.Drawing.Size(143, 20);
            this.txtidbill.TabIndex = 2;
            this.txtidbill.TextChanged += new System.EventHandler(this.txtidbill_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "ID Bill: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giá tiền:";
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.OldLace;
            this.txtprice.Location = new System.Drawing.Point(106, 177);
            this.txtprice.Margin = new System.Windows.Forms.Padding(2);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(143, 20);
            this.txtprice.TabIndex = 15;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "idBill";
            this.TenMon.HeaderText = "ID";
            this.TenMon.MinimumWidth = 8;
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            this.TenMon.Width = 50;
            // 
            // SLMon
            // 
            this.SLMon.DataPropertyName = "idEmployee";
            this.SLMon.HeaderText = "ID Nhân viên";
            this.SLMon.MinimumWidth = 8;
            this.SLMon.Name = "SLMon";
            this.SLMon.ReadOnly = true;
            // 
            // GiaMon
            // 
            this.GiaMon.DataPropertyName = "price";
            this.GiaMon.HeaderText = "Giá";
            this.GiaMon.MinimumWidth = 8;
            this.GiaMon.Name = "GiaMon";
            this.GiaMon.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "dateCheck";
            this.Date.HeaderText = "Ngày xuất HD";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phoneNumber";
            this.phone.HeaderText = "SDT";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Caddress";
            this.Address.HeaderText = "Địa chỉ khách hàng";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "nameCustomer";
            this.Name.HeaderText = "Tên khách hàng";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Visible = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.txtidbill);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtide);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(784, 430);
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtide;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtidbill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    }
}

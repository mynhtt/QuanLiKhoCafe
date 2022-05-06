namespace QuanLiQuanCafe
{
    partial class frmDatHang
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
            this.caPheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbQuanLyKhoCaPheDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_QuanLyKhoCaPheDataSet = new QuanLiQuanCafe.db_QuanLyKhoCaPheDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.nmudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnThemDDH = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXemTruocDDH = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbThanhTien = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtbTongCong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.caPheTableAdapter = new QuanLiQuanCafe.db_QuanLyKhoCaPheDataSetTableAdapters.CaPheTableAdapter();
            this.cbbNguonNhap = new System.Windows.Forms.ComboBox();
            this.nguonNhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguonNhapHangTableAdapter = new QuanLiQuanCafe.db_QuanLyKhoCaPheDataSetTableAdapters.NguonNhapHangTableAdapter();
            this.txtbTenSPDH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvSP = new System.Windows.Forms.DataGridView();
            this.TenSPDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSPDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvDSSPDH = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbMaSPDH = new System.Windows.Forms.TextBox();
            this.DDH_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDH_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDH_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDH_GiaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDH_TongCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.caPheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQuanLyKhoCaPheDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_QuanLyKhoCaPheDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguonNhapHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSPDH)).BeginInit();
            this.SuspendLayout();
            // 
            // caPheBindingSource
            // 
            this.caPheBindingSource.DataMember = "CaPhe";
            this.caPheBindingSource.DataSource = this.dbQuanLyKhoCaPheDataSetBindingSource;
            // 
            // dbQuanLyKhoCaPheDataSetBindingSource
            // 
            this.dbQuanLyKhoCaPheDataSetBindingSource.DataSource = this.db_QuanLyKhoCaPheDataSet;
            this.dbQuanLyKhoCaPheDataSetBindingSource.Position = 0;
            // 
            // db_QuanLyKhoCaPheDataSet
            // 
            this.db_QuanLyKhoCaPheDataSet.DataSetName = "db_QuanLyKhoCaPheDataSet";
            this.db_QuanLyKhoCaPheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nguồn nhập:";
            // 
            // nmudSoLuong
            // 
            this.nmudSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nmudSoLuong.Location = new System.Drawing.Point(769, 98);
            this.nmudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudSoLuong.Name = "nmudSoLuong";
            this.nmudSoLuong.Size = new System.Drawing.Size(55, 26);
            this.nmudSoLuong.TabIndex = 4;
            this.nmudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSP.BackColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(900, 68);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(159, 84);
            this.btnThemSP.TabIndex = 5;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnThemDDH
            // 
            this.btnThemDDH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemDDH.BackColor = System.Drawing.Color.White;
            this.btnThemDDH.Location = new System.Drawing.Point(1164, 32);
            this.btnThemDDH.Name = "btnThemDDH";
            this.btnThemDDH.Size = new System.Drawing.Size(114, 49);
            this.btnThemDDH.TabIndex = 6;
            this.btnThemDDH.Text = "Thêm Đơn đặt hàng";
            this.btnThemDDH.UseVisualStyleBackColor = false;
            this.btnThemDDH.Click += new System.EventHandler(this.btnThemDDH_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(1164, 98);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(114, 49);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXemTruocDDH
            // 
            this.btnXemTruocDDH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemTruocDDH.BackColor = System.Drawing.Color.White;
            this.btnXemTruocDDH.Location = new System.Drawing.Point(1164, 164);
            this.btnXemTruocDDH.Name = "btnXemTruocDDH";
            this.btnXemTruocDDH.Size = new System.Drawing.Size(114, 49);
            this.btnXemTruocDDH.TabIndex = 8;
            this.btnXemTruocDDH.Text = "Xem trước";
            this.btnXemTruocDDH.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(32, 517);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(140, 78);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(999, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thành tiền:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(999, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "VAT:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(999, 590);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tổng cộng:";
            // 
            // txtbThanhTien
            // 
            this.txtbThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbThanhTien.Location = new System.Drawing.Point(1125, 499);
            this.txtbThanhTien.Name = "txtbThanhTien";
            this.txtbThanhTien.ReadOnly = true;
            this.txtbThanhTien.Size = new System.Drawing.Size(117, 26);
            this.txtbThanhTien.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(1125, 543);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(117, 26);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "8%";
            // 
            // txtbTongCong
            // 
            this.txtbTongCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbTongCong.Location = new System.Drawing.Point(1125, 587);
            this.txtbTongCong.Name = "txtbTongCong";
            this.txtbTongCong.ReadOnly = true;
            this.txtbTongCong.Size = new System.Drawing.Size(117, 26);
            this.txtbTongCong.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1248, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "VND";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1248, 590);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "VND";
            // 
            // caPheTableAdapter
            // 
            this.caPheTableAdapter.ClearBeforeFill = true;
            // 
            // cbbNguonNhap
            // 
            this.cbbNguonNhap.DataSource = this.nguonNhapHangBindingSource;
            this.cbbNguonNhap.DisplayMember = "TenNNh";
            this.cbbNguonNhap.FormattingEnabled = true;
            this.cbbNguonNhap.Location = new System.Drawing.Point(536, 44);
            this.cbbNguonNhap.Name = "cbbNguonNhap";
            this.cbbNguonNhap.Size = new System.Drawing.Size(188, 28);
            this.cbbNguonNhap.TabIndex = 23;
            this.cbbNguonNhap.ValueMember = "MaNNH";
            // 
            // nguonNhapHangBindingSource
            // 
            this.nguonNhapHangBindingSource.DataMember = "NguonNhapHang";
            this.nguonNhapHangBindingSource.DataSource = this.dbQuanLyKhoCaPheDataSetBindingSource;
            // 
            // nguonNhapHangTableAdapter
            // 
            this.nguonNhapHangTableAdapter.ClearBeforeFill = true;
            // 
            // txtbTenSPDH
            // 
            this.txtbTenSPDH.BackColor = System.Drawing.Color.White;
            this.txtbTenSPDH.Location = new System.Drawing.Point(536, 98);
            this.txtbTenSPDH.Name = "txtbTenSPDH";
            this.txtbTenSPDH.ReadOnly = true;
            this.txtbTenSPDH.Size = new System.Drawing.Size(187, 26);
            this.txtbTenSPDH.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // dtgvSP
            // 
            this.dtgvSP.AllowUserToAddRows = false;
            this.dtgvSP.AllowUserToDeleteRows = false;
            this.dtgvSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvSP.BackgroundColor = System.Drawing.Color.White;
            this.dtgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSPDH,
            this.MaSPDH});
            this.dtgvSP.Location = new System.Drawing.Point(13, 13);
            this.dtgvSP.Name = "dtgvSP";
            this.dtgvSP.ReadOnly = true;
            this.dtgvSP.RowHeadersWidth = 62;
            this.dtgvSP.RowTemplate.Height = 28;
            this.dtgvSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSP.Size = new System.Drawing.Size(355, 200);
            this.dtgvSP.TabIndex = 26;
            this.dtgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSP_CellClick);
            // 
            // TenSPDH
            // 
            this.TenSPDH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSPDH.DataPropertyName = "TenSP";
            this.TenSPDH.HeaderText = "Tên sản phẩm đặt hàng";
            this.TenSPDH.MinimumWidth = 8;
            this.TenSPDH.Name = "TenSPDH";
            this.TenSPDH.ReadOnly = true;
            // 
            // MaSPDH
            // 
            this.MaSPDH.DataPropertyName = "MaSP";
            this.MaSPDH.HeaderText = "Mã sản phẩm đặt hàng";
            this.MaSPDH.MinimumWidth = 8;
            this.MaSPDH.Name = "MaSPDH";
            this.MaSPDH.ReadOnly = true;
            this.MaSPDH.Visible = false;
            this.MaSPDH.Width = 150;
            // 
            // dtgvDSSPDH
            // 
            this.dtgvDSSPDH.AllowUserToAddRows = false;
            this.dtgvDSSPDH.AllowUserToDeleteRows = false;
            this.dtgvDSSPDH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDSSPDH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDSSPDH.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDSSPDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSSPDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DDH_MaSP,
            this.DDH_TenSP,
            this.DDH_SoLuong,
            this.DDH_GiaMua,
            this.DDH_TongCong});
            this.dtgvDSSPDH.Location = new System.Drawing.Point(1, 231);
            this.dtgvDSSPDH.Name = "dtgvDSSPDH";
            this.dtgvDSSPDH.RowHeadersWidth = 62;
            this.dtgvDSSPDH.RowTemplate.Height = 28;
            this.dtgvDSSPDH.Size = new System.Drawing.Size(1345, 253);
            this.dtgvDSSPDH.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // txtbMaSPDH
            // 
            this.txtbMaSPDH.BackColor = System.Drawing.Color.White;
            this.txtbMaSPDH.Location = new System.Drawing.Point(536, 150);
            this.txtbMaSPDH.Name = "txtbMaSPDH";
            this.txtbMaSPDH.ReadOnly = true;
            this.txtbMaSPDH.Size = new System.Drawing.Size(187, 26);
            this.txtbMaSPDH.TabIndex = 28;
            // 
            // DDH_MaSP
            // 
            this.DDH_MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DDH_MaSP.HeaderText = "Mã sản phẩm";
            this.DDH_MaSP.MinimumWidth = 8;
            this.DDH_MaSP.Name = "DDH_MaSP";
            // 
            // DDH_TenSP
            // 
            this.DDH_TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DDH_TenSP.HeaderText = "Tên sản phẩm";
            this.DDH_TenSP.MinimumWidth = 8;
            this.DDH_TenSP.Name = "DDH_TenSP";
            // 
            // DDH_SoLuong
            // 
            this.DDH_SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DDH_SoLuong.HeaderText = "Số lượng";
            this.DDH_SoLuong.MinimumWidth = 8;
            this.DDH_SoLuong.Name = "DDH_SoLuong";
            // 
            // DDH_GiaMua
            // 
            this.DDH_GiaMua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DDH_GiaMua.HeaderText = "Giá mua";
            this.DDH_GiaMua.MinimumWidth = 8;
            this.DDH_GiaMua.Name = "DDH_GiaMua";
            // 
            // DDH_TongCong
            // 
            this.DDH_TongCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DDH_TongCong.HeaderText = "Tổng cộng";
            this.DDH_TongCong.MinimumWidth = 8;
            this.DDH_TongCong.Name = "DDH_TongCong";
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1346, 638);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbMaSPDH);
            this.Controls.Add(this.dtgvDSSPDH);
            this.Controls.Add(this.dtgvSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbTenSPDH);
            this.Controls.Add(this.cbbNguonNhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbTongCong);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtbThanhTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXemTruocDDH);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThemDDH);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.nmudSoLuong);
            this.Controls.Add(this.label1);
            this.Name = "frmDatHang";
            this.Text = "Đặt hàng";
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caPheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQuanLyKhoCaPheDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_QuanLyKhoCaPheDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguonNhapHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSPDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmudSoLuong;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnThemDDH;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXemTruocDDH;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbThanhTien;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtbTongCong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource dbQuanLyKhoCaPheDataSetBindingSource;
        private db_QuanLyKhoCaPheDataSet db_QuanLyKhoCaPheDataSet;
        private System.Windows.Forms.BindingSource caPheBindingSource;
        private db_QuanLyKhoCaPheDataSetTableAdapters.CaPheTableAdapter caPheTableAdapter;
        private System.Windows.Forms.ComboBox cbbNguonNhap;
        private System.Windows.Forms.BindingSource nguonNhapHangBindingSource;
        private db_QuanLyKhoCaPheDataSetTableAdapters.NguonNhapHangTableAdapter nguonNhapHangTableAdapter;
        private System.Windows.Forms.TextBox txtbTenSPDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvSP;
        private System.Windows.Forms.DataGridView dtgvDSSPDH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbMaSPDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSPDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSPDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDH_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDH_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDH_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDH_GiaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDH_TongCong;
    }
}
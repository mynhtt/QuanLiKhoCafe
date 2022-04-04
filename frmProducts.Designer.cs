
namespace QuanLiQuanCafe
{
    partial class frmProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.chkbPrice = new System.Windows.Forms.CheckBox();
            this.chkbName = new System.Windows.Forms.CheckBox();
            this.chkbType = new System.Windows.Forms.CheckBox();
            this.chkbID = new System.Windows.Forms.CheckBox();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            this.iconButtonRefresh = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbGoiY = new System.Windows.Forms.TextBox();
            this.txbHuongVi = new System.Windows.Forms.TextBox();
            this.txbCongThuc = new System.Windows.Forms.TextBox();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGoiY = new System.Windows.Forms.Label();
            this.labelHuongVi = new System.Windows.Forms.Label();
            this.labelCongThuc = new System.Windows.Forms.Label();
            this.labelLoaiCafe = new System.Windows.Forms.Label();
            this.labelDongia = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvData
            // 
            this.dtgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvData.BackgroundColor = System.Drawing.Color.White;
            this.dtgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvData.GridColor = System.Drawing.Color.White;
            this.dtgvData.Location = new System.Drawing.Point(4, 82);
            this.dtgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.ReadOnly = true;
            this.dtgvData.RowHeadersVisible = false;
            this.dtgvData.RowHeadersWidth = 51;
            this.dtgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvData.Size = new System.Drawing.Size(540, 459);
            this.dtgvData.TabIndex = 0;
            this.dtgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvData_CellClick);
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(48, 15);
            this.txbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(289, 22);
            this.txbTimKiem.TabIndex = 4;
            // 
            // chkbPrice
            // 
            this.chkbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkbPrice.AutoSize = true;
            this.chkbPrice.Location = new System.Drawing.Point(332, 7);
            this.chkbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.chkbPrice.Name = "chkbPrice";
            this.chkbPrice.Size = new System.Drawing.Size(50, 20);
            this.chkbPrice.TabIndex = 3;
            this.chkbPrice.Text = "Giá";
            this.chkbPrice.UseVisualStyleBackColor = true;
            // 
            // chkbName
            // 
            this.chkbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkbName.AutoSize = true;
            this.chkbName.Location = new System.Drawing.Point(179, 7);
            this.chkbName.Margin = new System.Windows.Forms.Padding(4);
            this.chkbName.Name = "chkbName";
            this.chkbName.Size = new System.Drawing.Size(115, 20);
            this.chkbName.TabIndex = 2;
            this.chkbName.Text = "Tên sản phẩm";
            this.chkbName.UseVisualStyleBackColor = true;
            // 
            // chkbType
            // 
            this.chkbType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkbType.AutoSize = true;
            this.chkbType.Location = new System.Drawing.Point(65, 7);
            this.chkbType.Margin = new System.Windows.Forms.Padding(4);
            this.chkbType.Name = "chkbType";
            this.chkbType.Size = new System.Drawing.Size(84, 20);
            this.chkbType.TabIndex = 1;
            this.chkbType.Text = "Loại cafe";
            this.chkbType.UseVisualStyleBackColor = true;
            // 
            // chkbID
            // 
            this.chkbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkbID.AutoSize = true;
            this.chkbID.Location = new System.Drawing.Point(5, 7);
            this.chkbID.Margin = new System.Windows.Forms.Padding(4);
            this.chkbID.Name = "chkbID";
            this.chkbID.Size = new System.Drawing.Size(42, 20);
            this.chkbID.TabIndex = 0;
            this.chkbID.Text = "ID";
            this.chkbID.UseVisualStyleBackColor = true;
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonDelete.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButtonDelete.IconColor = System.Drawing.Color.White;
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.IconSize = 30;
            this.iconButtonDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonDelete.Location = new System.Drawing.Point(985, 492);
            this.iconButtonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(100, 50);
            this.iconButtonDelete.TabIndex = 10;
            this.iconButtonDelete.UseVisualStyleBackColor = false;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // iconButtonRefresh
            // 
            this.iconButtonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonRefresh.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.iconButtonRefresh.IconColor = System.Drawing.Color.White;
            this.iconButtonRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRefresh.IconSize = 30;
            this.iconButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonRefresh.Location = new System.Drawing.Point(665, 492);
            this.iconButtonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonRefresh.Name = "iconButtonRefresh";
            this.iconButtonRefresh.Size = new System.Drawing.Size(100, 50);
            this.iconButtonRefresh.TabIndex = 12;
            this.iconButtonRefresh.UseVisualStyleBackColor = false;
            this.iconButtonRefresh.Click += new System.EventHandler(this.iconButtonRefresh_Click);
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButtonSave.IconColor = System.Drawing.Color.White;
            this.iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave.IconSize = 30;
            this.iconButtonSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonSave.Location = new System.Drawing.Point(825, 492);
            this.iconButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(100, 50);
            this.iconButtonSave.TabIndex = 13;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.FlatAppearance.BorderSize = 0;
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSearch.IconColor = System.Drawing.Color.Black;
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 30;
            this.iconButtonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonSearch.Location = new System.Drawing.Point(4, 5);
            this.iconButtonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(36, 42);
            this.iconButtonSearch.TabIndex = 14;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.chkbName);
            this.panelFilter.Controls.Add(this.chkbPrice);
            this.panelFilter.Controls.Add(this.chkbID);
            this.panelFilter.Controls.Add(this.chkbType);
            this.panelFilter.Location = new System.Drawing.Point(4, 47);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(4);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(400, 41);
            this.panelFilter.TabIndex = 15;
            // 
            // panelDetail
            // 
            this.panelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDetail.Controls.Add(this.cmbType);
            this.panelDetail.Controls.Add(this.nmSoLuong);
            this.panelDetail.Controls.Add(this.txbPrice);
            this.panelDetail.Controls.Add(this.txbGoiY);
            this.panelDetail.Controls.Add(this.txbHuongVi);
            this.panelDetail.Controls.Add(this.txbCongThuc);
            this.panelDetail.Controls.Add(this.txbTen);
            this.panelDetail.Controls.Add(this.txbID);
            this.panelDetail.Controls.Add(this.label1);
            this.panelDetail.Controls.Add(this.labelGoiY);
            this.panelDetail.Controls.Add(this.labelHuongVi);
            this.panelDetail.Controls.Add(this.labelCongThuc);
            this.panelDetail.Controls.Add(this.labelLoaiCafe);
            this.panelDetail.Controls.Add(this.labelDongia);
            this.panelDetail.Controls.Add(this.labelSoLuong);
            this.panelDetail.Controls.Add(this.labelTen);
            this.panelDetail.Controls.Add(this.labelID);
            this.panelDetail.Location = new System.Drawing.Point(549, 26);
            this.panelDetail.Margin = new System.Windows.Forms.Padding(4);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(629, 459);
            this.panelDetail.TabIndex = 16;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Espresso",
            "Arabica",
            "Culi",
            "Robusta"});
            this.cmbType.Location = new System.Drawing.Point(237, 266);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(205, 24);
            this.cmbType.TabIndex = 18;
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmSoLuong.Location = new System.Drawing.Point(237, 170);
            this.nmSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.nmSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(160, 29);
            this.nmSoLuong.TabIndex = 17;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(237, 218);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(377, 29);
            this.txbPrice.TabIndex = 16;
            // 
            // txbGoiY
            // 
            this.txbGoiY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGoiY.Location = new System.Drawing.Point(237, 415);
            this.txbGoiY.Margin = new System.Windows.Forms.Padding(4);
            this.txbGoiY.Name = "txbGoiY";
            this.txbGoiY.Size = new System.Drawing.Size(377, 29);
            this.txbGoiY.TabIndex = 15;
            // 
            // txbHuongVi
            // 
            this.txbHuongVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHuongVi.Location = new System.Drawing.Point(237, 366);
            this.txbHuongVi.Margin = new System.Windows.Forms.Padding(4);
            this.txbHuongVi.Name = "txbHuongVi";
            this.txbHuongVi.Size = new System.Drawing.Size(377, 29);
            this.txbHuongVi.TabIndex = 14;
            // 
            // txbCongThuc
            // 
            this.txbCongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCongThuc.Location = new System.Drawing.Point(237, 316);
            this.txbCongThuc.Margin = new System.Windows.Forms.Padding(4);
            this.txbCongThuc.Name = "txbCongThuc";
            this.txbCongThuc.Size = new System.Drawing.Size(377, 29);
            this.txbCongThuc.TabIndex = 13;
            // 
            // txbTen
            // 
            this.txbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTen.Location = new System.Drawing.Point(237, 119);
            this.txbTen.Margin = new System.Windows.Forms.Padding(4);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(377, 29);
            this.txbTen.TabIndex = 10;
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(237, 70);
            this.txbID.Margin = new System.Windows.Forms.Padding(4);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(377, 29);
            this.txbID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÔNG TIN CHI TIẾT";
            // 
            // labelGoiY
            // 
            this.labelGoiY.AutoSize = true;
            this.labelGoiY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoiY.Location = new System.Drawing.Point(52, 417);
            this.labelGoiY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGoiY.Name = "labelGoiY";
            this.labelGoiY.Size = new System.Drawing.Size(170, 25);
            this.labelGoiY.TabIndex = 7;
            this.labelGoiY.Text = "Gợi ý khách hàng:";
            // 
            // labelHuongVi
            // 
            this.labelHuongVi.AutoSize = true;
            this.labelHuongVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHuongVi.Location = new System.Drawing.Point(52, 368);
            this.labelHuongVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHuongVi.Name = "labelHuongVi";
            this.labelHuongVi.Size = new System.Drawing.Size(95, 25);
            this.labelHuongVi.TabIndex = 6;
            this.labelHuongVi.Text = "Hương vị:";
            // 
            // labelCongThuc
            // 
            this.labelCongThuc.AutoSize = true;
            this.labelCongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCongThuc.Location = new System.Drawing.Point(52, 319);
            this.labelCongThuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCongThuc.Name = "labelCongThuc";
            this.labelCongThuc.Size = new System.Drawing.Size(108, 25);
            this.labelCongThuc.TabIndex = 5;
            this.labelCongThuc.Text = "Công thức:";
            // 
            // labelLoaiCafe
            // 
            this.labelLoaiCafe.AutoSize = true;
            this.labelLoaiCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiCafe.Location = new System.Drawing.Point(52, 270);
            this.labelLoaiCafe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoaiCafe.Name = "labelLoaiCafe";
            this.labelLoaiCafe.Size = new System.Drawing.Size(55, 25);
            this.labelLoaiCafe.TabIndex = 4;
            this.labelLoaiCafe.Text = "Loại:";
            // 
            // labelDongia
            // 
            this.labelDongia.AutoSize = true;
            this.labelDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDongia.Location = new System.Drawing.Point(52, 220);
            this.labelDongia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDongia.Name = "labelDongia";
            this.labelDongia.Size = new System.Drawing.Size(85, 25);
            this.labelDongia.TabIndex = 3;
            this.labelDongia.Text = "Đơn giá:";
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.Location = new System.Drawing.Point(52, 171);
            this.labelSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(96, 25);
            this.labelSoLuong.TabIndex = 2;
            this.labelSoLuong.Text = "Số lượng:";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.Location = new System.Drawing.Point(52, 122);
            this.labelTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(144, 25);
            this.labelTen.TabIndex = 1;
            this.labelTen.Text = "Tên sản phẩm:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(52, 73);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(137, 25);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Mã sản phẩm:";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1181, 545);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.iconButtonSearch);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.iconButtonRefresh);
            this.Controls.Add(this.iconButtonDelete);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.dtgvData);
            this.Controls.Add(this.panelFilter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.CheckBox chkbID;
        private System.Windows.Forms.CheckBox chkbName;
        private System.Windows.Forms.CheckBox chkbType;
        private System.Windows.Forms.CheckBox chkbPrice;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
        private FontAwesome.Sharp.IconButton iconButtonRefresh;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.TextBox txbGoiY;
        private System.Windows.Forms.TextBox txbHuongVi;
        private System.Windows.Forms.TextBox txbCongThuc;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGoiY;
        private System.Windows.Forms.Label labelHuongVi;
        private System.Windows.Forms.Label labelCongThuc;
        private System.Windows.Forms.Label labelLoaiCafe;
        private System.Windows.Forms.Label labelDongia;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.ComboBox cmbType;
    }
}
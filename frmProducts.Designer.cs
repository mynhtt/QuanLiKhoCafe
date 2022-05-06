
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.chkbPrice = new System.Windows.Forms.CheckBox();
            this.chkbName = new System.Windows.Forms.CheckBox();
            this.chkbType = new System.Windows.Forms.CheckBox();
            this.chkbID = new System.Windows.Forms.CheckBox();
            this.iconButtonRefresh = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbCongThuc = new System.Windows.Forms.TextBox();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGiaBan = new System.Windows.Forms.Label();
            this.labelLoaiCafe = new System.Windows.Forms.Label();
            this.labelGiaMua = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.db_QuanLyKhoCaPheDataSet = new QuanLiQuanCafe.db_QuanLyKhoCaPheDataSet();
            this.dbQuanLyKhoCaPheDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiCaPheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiCaPheTableAdapter = new QuanLiQuanCafe.db_QuanLyKhoCaPheDataSetTableAdapters.LoaiCaPheTableAdapter();
            this.txtbSoLuong = new System.Windows.Forms.TextBox();
            this.txtbLoaiCF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_QuanLyKhoCaPheDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQuanLyKhoCaPheDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiCaPheBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvData
            // 
            this.dtgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvData.BackgroundColor = System.Drawing.Color.White;
            this.dtgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvData.GridColor = System.Drawing.Color.White;
            this.dtgvData.Location = new System.Drawing.Point(4, 102);
            this.dtgvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.ReadOnly = true;
            this.dtgvData.RowHeadersVisible = false;
            this.dtgvData.RowHeadersWidth = 51;
            this.dtgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvData.Size = new System.Drawing.Size(608, 574);
            this.dtgvData.TabIndex = 0;
            this.dtgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvData_CellClick);
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(54, 19);
            this.txbTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(325, 26);
            this.txbTimKiem.TabIndex = 4;
            // 
            // chkbPrice
            // 
            this.chkbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkbPrice.AutoSize = true;
            this.chkbPrice.Location = new System.Drawing.Point(374, 9);
            this.chkbPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkbPrice.Name = "chkbPrice";
            this.chkbPrice.Size = new System.Drawing.Size(60, 24);
            this.chkbPrice.TabIndex = 3;
            this.chkbPrice.Text = "Giá";
            this.chkbPrice.UseVisualStyleBackColor = true;
            // 
            // chkbName
            // 
            this.chkbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkbName.AutoSize = true;
            this.chkbName.Location = new System.Drawing.Point(201, 9);
            this.chkbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkbName.Name = "chkbName";
            this.chkbName.Size = new System.Drawing.Size(136, 24);
            this.chkbName.TabIndex = 2;
            this.chkbName.Text = "Tên sản phẩm";
            this.chkbName.UseVisualStyleBackColor = true;
            // 
            // chkbType
            // 
            this.chkbType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkbType.AutoSize = true;
            this.chkbType.Location = new System.Drawing.Point(73, 9);
            this.chkbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkbType.Name = "chkbType";
            this.chkbType.Size = new System.Drawing.Size(100, 24);
            this.chkbType.TabIndex = 1;
            this.chkbType.Text = "Loại cafe";
            this.chkbType.UseVisualStyleBackColor = true;
            // 
            // chkbID
            // 
            this.chkbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkbID.AutoSize = true;
            this.chkbID.Location = new System.Drawing.Point(6, 9);
            this.chkbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkbID.Name = "chkbID";
            this.chkbID.Size = new System.Drawing.Size(52, 24);
            this.chkbID.TabIndex = 0;
            this.chkbID.Text = "ID";
            this.chkbID.UseVisualStyleBackColor = true;
            // 
            // iconButtonRefresh
            // 
            this.iconButtonRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButtonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.iconButtonRefresh.IconColor = System.Drawing.Color.Black;
            this.iconButtonRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRefresh.IconSize = 30;
            this.iconButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButtonRefresh.Location = new System.Drawing.Point(953, 622);
            this.iconButtonRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButtonRefresh.Name = "iconButtonRefresh";
            this.iconButtonRefresh.Size = new System.Drawing.Size(112, 45);
            this.iconButtonRefresh.TabIndex = 12;
            this.iconButtonRefresh.UseVisualStyleBackColor = false;
            this.iconButtonRefresh.Click += new System.EventHandler(this.iconButtonRefresh_Click);
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
            this.iconButtonSearch.Location = new System.Drawing.Point(4, 6);
            this.iconButtonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(40, 52);
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
            this.panelFilter.Location = new System.Drawing.Point(4, 59);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(450, 51);
            this.panelFilter.TabIndex = 15;
            // 
            // panelDetail
            // 
            this.panelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDetail.Controls.Add(this.txtbLoaiCF);
            this.panelDetail.Controls.Add(this.txtbSoLuong);
            this.panelDetail.Controls.Add(this.txbPrice);
            this.panelDetail.Controls.Add(this.txbCongThuc);
            this.panelDetail.Controls.Add(this.txbTen);
            this.panelDetail.Controls.Add(this.txbID);
            this.panelDetail.Controls.Add(this.label1);
            this.panelDetail.Controls.Add(this.labelGiaBan);
            this.panelDetail.Controls.Add(this.labelLoaiCafe);
            this.panelDetail.Controls.Add(this.labelGiaMua);
            this.panelDetail.Controls.Add(this.labelSoLuong);
            this.panelDetail.Controls.Add(this.labelTen);
            this.panelDetail.Controls.Add(this.labelID);
            this.panelDetail.Location = new System.Drawing.Point(618, 32);
            this.panelDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(708, 574);
            this.panelDetail.TabIndex = 16;
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(265, 398);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.ReadOnly = true;
            this.txbPrice.Size = new System.Drawing.Size(424, 33);
            this.txbPrice.TabIndex = 16;
            // 
            // txbCongThuc
            // 
            this.txbCongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCongThuc.Location = new System.Drawing.Point(265, 461);
            this.txbCongThuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCongThuc.Name = "txbCongThuc";
            this.txbCongThuc.ReadOnly = true;
            this.txbCongThuc.Size = new System.Drawing.Size(424, 33);
            this.txbCongThuc.TabIndex = 13;
            // 
            // txbTen
            // 
            this.txbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTen.Location = new System.Drawing.Point(265, 214);
            this.txbTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTen.Name = "txbTen";
            this.txbTen.ReadOnly = true;
            this.txbTen.Size = new System.Drawing.Size(424, 33);
            this.txbTen.TabIndex = 10;
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(265, 151);
            this.txbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(424, 33);
            this.txbID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÔNG TIN CHI TIẾT";
            // 
            // labelGiaBan
            // 
            this.labelGiaBan.AutoSize = true;
            this.labelGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaBan.Location = new System.Drawing.Point(56, 464);
            this.labelGiaBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGiaBan.Name = "labelGiaBan";
            this.labelGiaBan.Size = new System.Drawing.Size(102, 29);
            this.labelGiaBan.TabIndex = 5;
            this.labelGiaBan.Text = "Giá bán:";
            // 
            // labelLoaiCafe
            // 
            this.labelLoaiCafe.AutoSize = true;
            this.labelLoaiCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiCafe.Location = new System.Drawing.Point(56, 278);
            this.labelLoaiCafe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoaiCafe.Name = "labelLoaiCafe";
            this.labelLoaiCafe.Size = new System.Drawing.Size(65, 29);
            this.labelLoaiCafe.TabIndex = 4;
            this.labelLoaiCafe.Text = "Loại:";
            // 
            // labelGiaMua
            // 
            this.labelGiaMua.AutoSize = true;
            this.labelGiaMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaMua.Location = new System.Drawing.Point(56, 402);
            this.labelGiaMua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGiaMua.Name = "labelGiaMua";
            this.labelGiaMua.Size = new System.Drawing.Size(108, 29);
            this.labelGiaMua.TabIndex = 3;
            this.labelGiaMua.Text = "Giá mua:";
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoLuong.Location = new System.Drawing.Point(56, 340);
            this.labelSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(115, 29);
            this.labelSoLuong.TabIndex = 2;
            this.labelSoLuong.Text = "Số lượng:";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.Location = new System.Drawing.Point(56, 216);
            this.labelTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(172, 29);
            this.labelTen.TabIndex = 1;
            this.labelTen.Text = "Tên sản phẩm:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(56, 154);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(162, 29);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Mã sản phẩm:";
            // 
            // db_QuanLyKhoCaPheDataSet
            // 
            this.db_QuanLyKhoCaPheDataSet.DataSetName = "db_QuanLyKhoCaPheDataSet";
            this.db_QuanLyKhoCaPheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbQuanLyKhoCaPheDataSetBindingSource
            // 
            this.dbQuanLyKhoCaPheDataSetBindingSource.DataSource = this.db_QuanLyKhoCaPheDataSet;
            this.dbQuanLyKhoCaPheDataSetBindingSource.Position = 0;
            // 
            // loaiCaPheBindingSource
            // 
            this.loaiCaPheBindingSource.DataMember = "LoaiCaPhe";
            this.loaiCaPheBindingSource.DataSource = this.dbQuanLyKhoCaPheDataSetBindingSource;
            // 
            // loaiCaPheTableAdapter
            // 
            this.loaiCaPheTableAdapter.ClearBeforeFill = true;
            // 
            // txtbSoLuong
            // 
            this.txtbSoLuong.Location = new System.Drawing.Point(265, 344);
            this.txtbSoLuong.Name = "txtbSoLuong";
            this.txtbSoLuong.ReadOnly = true;
            this.txtbSoLuong.Size = new System.Drawing.Size(100, 26);
            this.txtbSoLuong.TabIndex = 19;
            // 
            // txtbLoaiCF
            // 
            this.txtbLoaiCF.Location = new System.Drawing.Point(265, 282);
            this.txtbLoaiCF.Name = "txtbLoaiCF";
            this.txtbLoaiCF.ReadOnly = true;
            this.txtbLoaiCF.Size = new System.Drawing.Size(424, 26);
            this.txtbLoaiCF.TabIndex = 20;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1329, 681);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.iconButtonSearch);
            this.Controls.Add(this.iconButtonRefresh);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.dtgvData);
            this.Controls.Add(this.panelFilter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProducts";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_QuanLyKhoCaPheDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQuanLyKhoCaPheDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiCaPheBindingSource)).EndInit();
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
        private FontAwesome.Sharp.IconButton iconButtonRefresh;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.TextBox txbCongThuc;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGiaBan;
        private System.Windows.Forms.Label labelLoaiCafe;
        private System.Windows.Forms.Label labelGiaMua;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.BindingSource dbQuanLyKhoCaPheDataSetBindingSource;
        private db_QuanLyKhoCaPheDataSet db_QuanLyKhoCaPheDataSet;
        private System.Windows.Forms.BindingSource loaiCaPheBindingSource;
        private db_QuanLyKhoCaPheDataSetTableAdapters.LoaiCaPheTableAdapter loaiCaPheTableAdapter;
        private System.Windows.Forms.TextBox txtbLoaiCF;
        private System.Windows.Forms.TextBox txtbSoLuong;
    }
}
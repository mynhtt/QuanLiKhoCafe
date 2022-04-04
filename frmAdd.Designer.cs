
namespace QuanLiQuanCafe
{
    partial class frmAdd
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtModify = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTaste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cafeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeInfoDataSet = new QuanLiQuanCafe.CafeInfoDataSet();
            this.cafeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeInfoDataSet2 = new QuanLiQuanCafe.CafeInfoDataSet2();
            this.cafeInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cafeInfoDataSet1 = new QuanLiQuanCafe.CafeInfoDataSet1();
            this.cafeInfoTableAdapter = new QuanLiQuanCafe.CafeInfoDataSetTableAdapters.CafeInfoTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cafeInfoTableAdapter1 = new QuanLiQuanCafe.CafeInfoDataSet1TableAdapters.CafeInfoTableAdapter();
            this.cafeTypeTableAdapter = new QuanLiQuanCafe.CafeInfoDataSet2TableAdapters.CafeTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cafeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeInfoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeInfoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(552, 263);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(118, 20);
            this.txtAmount.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(432, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Số lượng:";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(407, 327);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 27);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(200, 327);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 27);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtModify
            // 
            this.txtModify.Location = new System.Drawing.Point(151, 263);
            this.txtModify.Name = "txtModify";
            this.txtModify.Size = new System.Drawing.Size(114, 20);
            this.txtModify.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mô tả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 31);
            this.label7.TabIndex = 32;
            this.label7.Text = "THÊM SẢN PHẨM";
            // 
            // txtTaste
            // 
            this.txtTaste.Location = new System.Drawing.Point(552, 216);
            this.txtTaste.Name = "txtTaste";
            this.txtTaste.Size = new System.Drawing.Size(118, 20);
            this.txtTaste.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Vị:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(151, 216);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(114, 20);
            this.txtNote.TabIndex = 29;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(552, 169);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(118, 20);
            this.txtPrice.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(552, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 20);
            this.txtName.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Đơn giá/kg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Loại hạt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(151, 112);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 20);
            this.txtID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Espresso",
            "Arabica",
            "Robusta",
            "Culi"});
            this.cmbType.Location = new System.Drawing.Point(151, 167);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(114, 21);
            this.cmbType.TabIndex = 39;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cafeInfoBindingSource
            // 
            this.cafeInfoBindingSource.DataMember = "CafeInfo";
            this.cafeInfoBindingSource.DataSource = this.cafeInfoDataSet;
            // 
            // cafeInfoDataSet
            // 
            this.cafeInfoDataSet.DataSetName = "CafeInfoDataSet";
            this.cafeInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cafeTypeBindingSource
            // 
            this.cafeTypeBindingSource.DataMember = "CafeType";
            this.cafeTypeBindingSource.DataSource = this.cafeInfoDataSet2;
            // 
            // cafeInfoDataSet2
            // 
            this.cafeInfoDataSet2.DataSetName = "CafeInfoDataSet2";
            this.cafeInfoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cafeInfoBindingSource1
            // 
            this.cafeInfoBindingSource1.DataMember = "CafeInfo";
            this.cafeInfoBindingSource1.DataSource = this.cafeInfoDataSet1;
            // 
            // cafeInfoDataSet1
            // 
            this.cafeInfoDataSet1.DataSetName = "CafeInfoDataSet1";
            this.cafeInfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cafeInfoTableAdapter
            // 
            this.cafeInfoTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(676, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "kg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(676, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "VNĐ";
            // 
            // cafeInfoTableAdapter1
            // 
            this.cafeInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // cafeTypeTableAdapter
            // 
            this.cafeTypeTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 409);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtModify);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTaste);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeInfoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeInfoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtModify;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTaste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private CafeInfoDataSet cafeInfoDataSet;
        private System.Windows.Forms.BindingSource cafeInfoBindingSource;
        private CafeInfoDataSetTableAdapters.CafeInfoTableAdapter cafeInfoTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private CafeInfoDataSet1 cafeInfoDataSet1;
        private System.Windows.Forms.BindingSource cafeInfoBindingSource1;
        private CafeInfoDataSet1TableAdapters.CafeInfoTableAdapter cafeInfoTableAdapter1;
        private CafeInfoDataSet2 cafeInfoDataSet2;
        private System.Windows.Forms.BindingSource cafeTypeBindingSource;
        private CafeInfoDataSet2TableAdapters.CafeTypeTableAdapter cafeTypeTableAdapter;
    }
}
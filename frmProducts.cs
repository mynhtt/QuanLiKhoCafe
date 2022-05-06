using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS_QuanLiKhoCafe;
using DTO_QuanLiKhoCafe;

namespace QuanLiQuanCafe
{   
     
    public partial class frmProducts : Form
    {
        BUS_cafeinfo buscafeinfo = new BUS_cafeinfo();
        DataClasses1DataContext db = new DataClasses1DataContext();

        public frmProducts()
        {
            InitializeComponent();
        }

        #region methods
        void LoadCafeInfo()
        {
            dtgvData.DataSource = buscafeinfo.getcafeinfo();
        }

        void ClearThongTinChiTiet()
        {
            txbID.DataBindings.Clear();
            txbTen.DataBindings.Clear();
            txbPrice.DataBindings.Clear();
            txtbSoLuong.DataBindings.Clear();
            txbCongThuc.DataBindings.Clear();
            txtbLoaiCF.DataBindings.Clear();    
        }

        void LoadThongTinChiTiet()
        {
            ClearThongTinChiTiet();
            txbID.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Mã sản phẩm"));
            txbTen.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Tên sản phẩm"));
            txbPrice.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Giá mua"));
            txtbSoLuong.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Số lượng"));
            txbCongThuc.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Giá bán"));
            txtbLoaiCF.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Loại cà phê"));
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_QuanLyKhoCaPheDataSet.LoaiCaPhe' table. You can move, or remove it, as needed.
            this.loaiCaPheTableAdapter.Fill(this.db_QuanLyKhoCaPheDataSet.LoaiCaPhe);
            dtgvData.DataSource = buscafeinfo.getcafeinfo();
        }

        /*void LuuThongTin()
        {
            try
            {
                string id = txbID.Text;
                string loaicf = cmbLoaiCF.Text;
                string ten = txbTen.Text;
                float giamua = float.Parse(txbPrice.Text);
                float soluong = float.Parse(nmSoLuong.Value.ToString());
                float giaban = float.Parse(txbCongThuc.Text);

                DTO_CaPhe edit = new DTO_CaPhe();

                edit.MaSP = id;
                edit.MaLoaiCF = loaicf;
                edit.TenSP = ten;
                edit.GiaMua = giamua;
                edit.GiaBan = giaban;

                if (buscafeinfo.updateCafeInfo(edit))
                {
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông Báo");  
            }
            
        }*/

        /*void XoaThongTin()
        {
            string id = txbID.Text;
            //buscafeinfo.deleteCafeInfo(id);
            LoadCafeInfo();
        }*/

        #endregion

        #region events
        //Xóa
        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            //XoaThongTin();
        }

        //Làm mới datagridview
        private void iconButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadCafeInfo();
            txbTimKiem.Text = "";
        }

        //lưu sau khi sửa
        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            //LuuThongTin();
            LoadCafeInfo();
        }

        // tìm kiếm
        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            if (chkbID.Checked)
            {
                dtgvData.DataSource = buscafeinfo.SearchCafeinfo("MaSP", txbTimKiem.Text);
            }
            if (chkbType.Checked)
            {
                dtgvData.DataSource = buscafeinfo.SearchCafeinfo("MaLoaiCF", txbTimKiem.Text); //tìm kiếm theo loại cafe
            } 
            if (chkbName.Checked)
            {
                dtgvData.DataSource = buscafeinfo.SearchCafeinfo("TenSP", txbTimKiem.Text); //tìm kiếm theo tên sản phẩm
            } 
            if (chkbPrice.Checked)
            {
                dtgvData.DataSource = buscafeinfo.SearchCafeinfo("cafePrice", txbTimKiem.Text);//tìm kiếm theo giá
            } 
        }
        
        // load thông tin chi tiết khi click vào từng sản phẩm
        private void dtgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadThongTinChiTiet();
            
        }




        #endregion
    }
}

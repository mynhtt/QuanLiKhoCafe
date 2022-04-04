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
using BUS;
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
            nmSoLuong.DataBindings.Clear();
            txbCongThuc.DataBindings.Clear();
            txbHuongVi.DataBindings.Clear();
            txbGoiY.DataBindings.Clear();
        }

        void LoadThongTinChiTiet()
        {
            ClearThongTinChiTiet();
            txbID.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Mã sản phẩm"));
            txbTen.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Tên sản phẩm"));
            txbPrice.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Giá Tiền"));
            nmSoLuong.DataBindings.Add(new Binding("Value", dtgvData.DataSource, "Số lượng"));
            txbCongThuc.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Công thức"));
            txbHuongVi.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Hương vị"));
            txbGoiY.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Gợi ý khách hàng"));
            
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            dtgvData.DataSource = buscafeinfo.getcafeinfo();
        }

        void LuuThongTin()
        {
            try
            {
                string id = txbID.Text;
                string loaicf = cmbType.Text;
                string ten = txbTen.Text;
                float dongia = float.Parse(txbPrice.Text);
                float soluong = float.Parse(nmSoLuong.Value.ToString());
                string congthuc = txbCongThuc.Text;
                string huongvi = txbHuongVi.Text;
                string goiy = txbGoiY.Text;

                DTO.cafeinfo edit = new cafeinfo();

                edit.ID = id;
                edit.cafeType = loaicf;
                edit.cafeName = ten;
                edit.cafePrice = dongia;
                edit.cafeAmount = soluong;
                edit.cafeNote = congthuc;
                edit.cafeTaste = huongvi;
                edit.cafeModify = goiy;

                if (buscafeinfo.updateCafeInfo(edit))
                {
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông Báo");  
            }
            
        }

        void XoaThongTin()
        {
            string id = txbID.Text;
            buscafeinfo.deleteCafeInfo(id);
            LoadCafeInfo();
        }

        #endregion

        #region events
        //Xóa
        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            XoaThongTin();
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
            LuuThongTin();
            LoadCafeInfo();
        }

        // tìm kiếm
        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            if (chkbID.Checked)
            {
                dtgvData.DataSource = buscafeinfo.SearchCafeinfo("ID", txbTimKiem.Text);
            }
            if (chkbType.Checked)
            {
                dtgvData.DataSource = buscafeinfo.SearchCafeinfo("cafeType", txbTimKiem.Text); //tìm kiếm theo loại cafe
            } 
            if (chkbName.Checked)
            {
                dtgvData.DataSource = buscafeinfo.SearchCafeinfo("cafeName", txbTimKiem.Text); //tìm kiếm theo tên sản phẩm
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
            FrmChiTietSanPham frmChiTietSanPham = new FrmChiTietSanPham();
            frmChiTietSanPham.ShowDialog();
        }



        #endregion

        
    }
}

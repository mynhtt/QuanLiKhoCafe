using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLiQuanCafe
{
    public partial class frmIn : Form
    {
        BUS_ChiTietPhieuNhap ctNhap = new BUS_ChiTietPhieuNhap();
        BUS_ChiTietPhieuXuat ctXuat = new BUS_ChiTietPhieuXuat();
        public frmIn()
        {
            InitializeComponent();
            LoadThongTinPhieuNhap();
            LoadThongTinPhieuXuat();
        }

        private void frmIn_Load(object sender, EventArgs e)
        {

        }

        #region methods

        void LoadThongTinPhieuNhap()
        {
            dtgvHoaDonNhap.DataSource = ctNhap.getThongTinPhieuNhap();
        }
        void LoadThongTinPhieuXuat()
        {
            dtgvHoaDonXuat.DataSource = ctXuat.getThongTinPhieuXuat();
        }
        void XoaPhieuNhap()
        {
            ChiTietPhieuNhap_DTO pn = new ChiTietPhieuNhap_DTO();
            try
            {
                pn.IdNhap = txbID_N.Text;
                pn.IdSP = txbIdSP_N.Text;
                pn.SoLuong = Int32.Parse(txbSoLuong_N.Text);
                pn.TenSP = txbTenSP_N.Text;
                pn.NguonNhap = txbNguonNhap.Text;
                pn.DiaChi = txbDiaChi_N.Text;
                pn.NgayNhap = dtpNgayNhap.Value;
                pn.SDT = txbSDT_N.Text;
                if (ctNhap.xoaPhieuNhap(pn.IdNhap,pn.IdSP))
                {
                    MessageBox.Show("Xoá phiếu nhập thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xoá phiếu nhập không thành công", "Thông báo");
                }
                LoadThongTinPhieuNhap();
                txbIdSP_N.Text = "";
                txbID_N.Text = "";
                txbTenSP_N.Text = "";
                txbSoLuong_N.Text = "";
                txbNguonNhap.Text = "";
                txbDiaChi_N.Text = "";
                txbSDT_N.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ ");
            }
        }

        void ThemPhieuNhap()
        {
            ChiTietPhieuNhap_DTO pn = new ChiTietPhieuNhap_DTO();
            try
            {
                pn.IdNhap = txbID_N.Text;
                pn.IdSP = txbIdSP_N.Text;
                pn.SoLuong = Int32.Parse(txbSoLuong_N.Text);
                pn.TenSP = txbTenSP_N.Text;
                pn.NguonNhap = txbNguonNhap.Text;
                pn.DiaChi = txbDiaChi_N.Text;
                pn.NgayNhap = dtpNgayNhap.Value;
                pn.SDT = txbSDT_N.Text;
                if (ctNhap.themPhieuNhap(pn))
                {
                    MessageBox.Show("Tạo phiếu nhập thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Tạo phiếu nhập không thành công", "Thông báo");
                }

                LoadThongTinPhieuNhap();
                txbIdSP_N.Text = "";
                txbID_N.Text = "";
                txbTenSP_N.Text = "";
                txbSoLuong_N.Text = "";
                txbNguonNhap.Text = "";
                txbDiaChi_N.Text = "";
                txbSDT_N.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ ");   
            }
            
            
        }
        void ClearThongTinChiTiet()
        {
            txbID_N.DataBindings.Clear();
            txbIdSP_N.DataBindings.Clear();
            txbTenSP_N.DataBindings.Clear();
            txbSoLuong_N.DataBindings.Clear();
            dtpNgayNhap.DataBindings.Clear();
            txbNguonNhap.DataBindings.Clear();
            txbDiaChi_N.DataBindings.Clear();
            txbSDT_N.DataBindings.Clear();

        }
        void LoadThongTinChiTiet()
        {
            ClearThongTinChiTiet();
            txbID_N.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Mã phiếu nhập"));
            txbIdSP_N.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Mã sản phẩm"));
            txbTenSP_N.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Tên sản phẩm"));
            txbSoLuong_N.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Số lượng"));
            dtpNgayNhap.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Ngày nhập"));
            txbNguonNhap.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Nguồn nhập"));
            txbDiaChi_N.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Địa chỉ"));
            txbSDT_N.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Số điện thoại"));

        }
        
        void ThemPhieuXuat()
        {
            ChiTietPhieuXuat_DTO pn =  new ChiTietPhieuXuat_DTO();
            try
            {
                pn.IdXuat = txtMPX.Text;
                pn.IdNhap = txtMPN.Text;
                pn.TenSP = txtTSP.Text;
                pn.SoLuong = Int32.Parse(txtSL.Text);
                pn.TenKH = txtKH.Text;
                pn.DiaChi = txtDC.Text;
                pn.NgayNhap = dTP.Value;
                pn.SDT = txtSDT.Text;
                if (ctXuat.themPhieuXuat(pn))
                {

                    MessageBox.Show("Tạo phiếu nhập thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Tạo phiếu nhập không thành công", "Thông báo");
                }
                LoadThongTinPhieuXuat();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ ");
            }
            
            

            
        }



        #endregion

        #region events
        private void icbNThem_Click(object sender, EventArgs e)
        {
            ThemPhieuNhap();
        }
        private void icbSearch_Click(object sender, EventArgs e)
        {
            if (chkbXMHD.Checked)
            {
                dtgvHoaDonXuat.DataSource = ctXuat.SearchThongTinPhieuXuat("IDPhieuXuat", txbXSearch.Text);
            }
            if (chkbXTen.Checked)
            {
                dtgvHoaDonXuat.DataSource = ctXuat.SearchThongTinPhieuXuat("IDPhieuNhap", txbXSearch.Text);
            }
            if (chkbSDT.Checked)
            {
               
                dtgvHoaDonXuat.DataSource = ctXuat.SearchThongTinPhieuXuat("TenSanPham", txbXSearch.Text);
            }
        }
        #endregion
        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ThemPhieuXuat();
        }
          
        private void icbNTimKiem_Click(object sender, EventArgs e)
        {
            if (chkbNMaHD.Checked)
            {
                dtgvHoaDonNhap.DataSource = ctNhap.SearchThongTinPhieuNhap("IDPhieuNhap", txbNTimKiem.Text);
            }
            if (chkbNTen.Checked)
            {
                dtgvHoaDonNhap.DataSource = ctNhap.SearchThongTinPhieuNhap("IDSanPham", txbNTimKiem.Text);
            }
            if (chkbNTSP.Checked)
            {
                dtgvHoaDonNhap.DataSource = ctNhap.SearchThongTinPhieuNhap("TenSanPham", txbNTimKiem.Text);
            }

        }

        private void dtgvHoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           LoadThongTinChiTiet();
        }

        private void iconButtonRefresh_Click(object sender, EventArgs e)
        {
            txbID_N.DataBindings.Clear();
            txbIdSP_N.DataBindings.Clear();
            txbTenSP_N.DataBindings.Clear();
            txbSoLuong_N.DataBindings.Clear();
            //tpNgayNhap.DataBindings.Clear();
            txbNguonNhap.DataBindings.Clear();
            txbDiaChi_N.DataBindings.Clear();
            txbSDT_N.DataBindings.Clear();
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            XoaPhieuNhap();
        }
    }
}

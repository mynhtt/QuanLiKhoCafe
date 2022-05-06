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
using DTO_QuanLiKhoCafe;
using BUS_QuanLiKhoCafe;

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
            // TODO: This line of code loads data into the 'db_QuanLyKhoCaPheDataSet.DonDatHang' table. You can move, or remove it, as needed.
            this.donDatHangTableAdapter.Fill(this.db_QuanLyKhoCaPheDataSet.DonDatHang);
            // TODO: This line of code loads data into the 'db_QuanLyKhoCaPheDataSet.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.chiTietHoaDonTableAdapter.Fill(this.db_QuanLyKhoCaPheDataSet.ChiTietHoaDon);

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
        /*void XoaPhieuNhap()
        {
            DTO_ChiTietDDH pn = new DTO_ChiTietDDH();
            try
            {
                pn.MaDDH= txbID_N.Text;
                pn.MaSP = txbIdSP_N.Text;
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
        }*/

        /*void ThemPhieuNhap()
        {
            DTO_ChiTietDDH pn = new DTO_ChiTietDDH();
            DTO_DDH dh = new DTO_DDH();
            try
            {
                pn.MaDDH = txtbMaDDH.Text;
                pn.MaSP = txtbMaNNH.Text;
                pn.SoLuong = Int32.Parse(txtbVAT_DDH.Text);
                pn.DonGia = int.Parse(txtbTongCong_DDH.Text);
                pn.ThanhTien = int.Parse(txtbNguonNhap.Text);
                *//*pn.DiaChi = txbDiaChi_N.Text;
                pn.NgayNhap = dtpNgayNhap.Value;
                pn.SDT = txbSDT_N.Text;*//*
                if (ctNhap.themPhieuNhap(pn, dh))
                {
                    MessageBox.Show("Tạo phiếu nhập thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Tạo phiếu nhập không thành công", "Thông báo");
                }

                LoadThongTinPhieuNhap();
                txtbMaNNH.Text = "";
                txtbMaDDH.Text = "";
                txtbTongCong_DDH.Text = "";
                txtbVAT_DDH.Text = "";
                txtbNguonNhap.Text = "";
                txtbSDT_DDH.Text = "";
                txtbThanhTien_DDH.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
            
            
        }*/
        void ClearThongTinChiTiet()
        {
            txtbMaDDH.DataBindings.Clear();
            txtbMaNNH.DataBindings.Clear();
            txtbTongCong_DDH.DataBindings.Clear();
            txtbVAT_DDH.DataBindings.Clear();
            dtpNgayNhap.DataBindings.Clear();
            txtbNguonNhap.DataBindings.Clear();
            txtbSDT_DDH.DataBindings.Clear();
            txtbThanhTien_DDH.DataBindings.Clear();

        }
        void LoadThongTinChiTiet()
        {
            ClearThongTinChiTiet();
            txtbMaDDH.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Mã đơn đặt hàng"));
            txtbMaNNH.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Mã nguồn nhập hàng"));
            txtbTongCong_DDH.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Tổng cộng"));
            txtbVAT_DDH.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "VAT"));
            dtpNgayNhap.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Ngày đặt hàng"));
            txtbNguonNhap.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "Nguồn nhập"));
            txtbSDT_DDH.DataBindings.Add(new Binding("Text", dtgvHoaDonNhap.DataSource, "SDT"));
            txtbThanhTien_DDH.DataBindings.Add(new Binding("Text",dtgvHoaDonNhap.DataSource, "Thành tiền" ));

        }
        
        /*void ThemPhieuXuat()
        {
            DTO_ChiTietHoaDon pn =  new DTO_ChiTietHoaDon();
            DTO_HoaDon hd = new DTO_HoaDon();
            try
            {
                pn.MaHD = txtMPX.Text;
                pn.MaSP = txtMPN.Text;
                pn.DonGia = float.Parse(txtTSP.Text);
                pn.SoLuong = Int32.Parse(txtSL.Text);
                pn.ThanhTien = float.Parse(txtKH.Text);

                hd.MaHD = pn.MaHD;
                hd.MaKH = txtKH.Text;
                hd.NgayHD = dTP.Value;
                hd.TongTien = int.Parse(txtSL.Text) * int.Parse(txtTSP.Text);
                
                if (ctXuat.themPhieuXuat())
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
                MessageBox.Show(ex.Message);
            }
            
            

            
        }*/



        #endregion

        #region events
        private void icbNThem_Click(object sender, EventArgs e)
        {
            //ThemPhieuNhap();
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
            txtbMaDDH.DataBindings.Clear();
            txtbMaNNH.DataBindings.Clear();
            txtbTongCong_DDH.DataBindings.Clear();
            txtbVAT_DDH.DataBindings.Clear();
            //tpNgayNhap.DataBindings.Clear();
            txtbNguonNhap.DataBindings.Clear();
            txtbSDT_DDH.DataBindings.Clear();
            txtbThanhTien_DDH.DataBindings.Clear();
        }

        private void iconButtonDelete_Click(object sender, EventArgs e)
        {
            //XoaPhieuNhap();
        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            Form fDatHang = new frmDatHang();
            fDatHang.Show();
        }

        private void dtgvHoaDonNhap_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            LoadThongTinChiTiet();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
           Form fHoaDon = new frmHoaDon();
            fHoaDon.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

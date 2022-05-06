using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLiKhoCafe;
using BUS_QuanLiKhoCafe;

namespace QuanLiQuanCafe
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        bool daCoDon = false;
        BUS_XuLi xuLiBLL = new BUS_XuLi();
        BUS_cafeinfo busCF = new BUS_cafeinfo();

        public bool KiemTra()
        {

            if (nmudSoLuong.Value.ToString() == String.Empty)
            {
                MessageBox.Show("Số lượng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nmudSoLuong.Focus();

                return false;
            }

            return true;
        }

        private void dtgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvSP.Rows[e.RowIndex];

            txtbTenSPDH.Text = Convert.ToString(row.Cells["TenSP"].Value);
            txtbMaSPDH.Text = Convert.ToString(row.Cells["MaSP"].Value);
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_QuanLyKhoCaPheDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.db_QuanLyKhoCaPheDataSet.KhachHang);
            dtgvSP.DataSource = busCF.getDanhSachSPDH();
            dtgvSP.Enabled = false;

            btnThemDDH.Enabled = true;
            btnXemTruocDDH.Enabled = false;
            btnThanhToan.Enabled = false;
            cbbNguonNhap.Enabled = false;
            btnThemSP.Enabled = false;
            btnHuy.Enabled = false;
            nmudSoLuong.Enabled = false;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (txtbTenSPDH.Text == "")
                {
                    MessageBox.Show("Chưa chọn sản phẩm đặt hàng.");
                }
                else
                {
                    string tenSPDH = txtbTenSPDH.Text;
                    int SoLuongDH = Convert.ToInt32(nmudSoLuong.Value);
                    int maSP = Convert.ToInt32(txtbMaSPDH.Text);
                    int giaMua = xuLiBLL.GiaMuaSanPham(maSP);
                    int tongCong = SoLuongDH * giaMua;

                    if (daCoDon == false)
                    {
                        dtgvDSSPDH.Rows.Add(maSP, tenSPDH, SoLuongDH, giaMua, tongCong);
                        daCoDon = true;

                        txtbTenSPDH.Text = "";
                        txtbMaSPDH.Text = "";
                        nmudSoLuong.Value = 1;
                    }
                    else
                    {
                        bool kiemTra = false;
                        int nRow = dtgvDSSPDH.Rows.Count;
                        int indexRow = -1;

                        for (int i = 0; i < nRow; ++i)
                        {
                            DataGridViewRow row = dtgvDSSPDH.Rows[i];
                            if ((int)row.Cells["DDH_MaSP"].Value == maSP)
                            {
                                kiemTra = true;
                                indexRow = i;
                                break;
                            }
                        }

                        if (kiemTra == false)
                        {
                            dtgvDSSPDH.Rows.Add(maSP, tenSPDH, SoLuongDH, giaMua, tongCong);
                        }
                        else
                        {
                            dtgvDSSPDH.Rows[indexRow].Cells["DDH_SoLuong"].Value = (int)dtgvDSSPDH.Rows[indexRow].Cells["DDH_SoLuong"].Value + SoLuongDH;
                            dtgvDSSPDH.Rows[indexRow].Cells["DDH_TongCong"].Value = (int)dtgvDSSPDH.Rows[indexRow].Cells["DDH_SoLuong"].Value * (int)dtgvDSSPDH.Rows[indexRow].Cells["DDH_GiaMua"].Value;
                        }

                        txtbTenSPDH.Text = "";
                        txtbMaSPDH.Text = "";
                        nmudSoLuong.Value = 1;
                    }

                    int thanhTien = 0;
                    int tongTien = 0;

                    for (int i = 0; i < dtgvDSSPDH.Rows.Count - 1; ++i)
                    {
                        DataGridViewRow row = dtgvDSSPDH.Rows[i];
                        thanhTien += (int)row.Cells["DDH_TongCong"].Value;
                    }

                    tongTien = thanhTien + (thanhTien * 8) / 100;

                    txtbThanhTien.Text = thanhTien.ToString();
                    txtbTongCong.Text = tongTien.ToString();
                }
            }
            int tong = 0;

            txtbTongCong.Text = (tong * 0.08 + tong).ToString();
            txtbThanhTien.Text = tong.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            nmudSoLuong.Value = 0;
            txtbThanhTien.Text = "";
            txtbTongCong.Text = "";
            btnThemDDH.Enabled = true;
            btnXemTruocDDH.Enabled = false;
            btnThanhToan.Enabled = false;
            cbbNguonNhap.Enabled = false;
            btnThemSP.Enabled = false;
            btnHuy.Enabled = false;
            nmudSoLuong.Enabled = false;
            dtgvSP.Enabled = false;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            BUS_ChiTietPhieuXuat bUS_ChiTietPhieuXuat = new BUS_ChiTietPhieuXuat();

            bUS_ChiTietPhieuXuat.themPhieuXuat(int.Parse(cbbNguonNhap.SelectedValue.ToString()), int.Parse(txtbThanhTien.Text), int.Parse(txtbTongCong.Text));
            this.Close();
        }

        private void btnThemDDH_Click(object sender, EventArgs e)
        {
            btnThemDDH.Enabled = false;
            btnXemTruocDDH.Enabled = true;
            btnThanhToan.Enabled = true;
            cbbNguonNhap.Enabled = true;
            btnThemSP.Enabled = true;
            btnHuy.Enabled = true;
            nmudSoLuong.Enabled = true;
            dtgvSP.Enabled = true;
        }
    }
}

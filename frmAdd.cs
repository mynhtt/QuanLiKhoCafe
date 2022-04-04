using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DTO;
using BUS;

namespace QuanLiQuanCafe
{
    public partial class frmAdd : Form
    {
        BUS_cafeinfo buscfinfo = new BUS_cafeinfo();
        cafeinfo cf = new cafeinfo();
        DataClasses1DataContext db = new DataClasses1DataContext();

        public frmAdd()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
            
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Form f1 = new frmProducts();
            
            try
            {

                if (db.CafeInfos.Where(d => d.ID.Equals(cf.ID)).ToString() != txtID.Text)
                {
                    if (Int32.Parse(txtPrice.Text) > 50000)
                    {
                        if (cmbType.SelectedIndex.ToString() != "")
                        {

                            cf.ID = txtID.Text;
                            cf.cafeType = cmbType.SelectedIndex.ToString();
                            cf.cafeAmount = Int32.Parse(txtAmount.Text);
                            cf.cafeModify = txtModify.Text;
                            cf.cafeName = txtName.Text;
                            cf.cafePrice = Int32.Parse(txtPrice.Text);
                            cf.cafeNote = txtNote.Text;
                            cf.cafeTaste = txtTaste.Text;
                            if (buscfinfo.addcafeinfo(cf))
                            {
                                MessageBox.Show("Thêm thành công");
                                this.Close();
                            } else MessageBox.Show("Lỗi");
                            
                        } else MessageBox.Show("Vui lòng chọn loại hạt", "Thông báo");
                        
                    } else MessageBox.Show("Giá tiền không hợp lệ", "Thông báo");
                    
                } else MessageBox.Show("ID này đã tồn tại. Vui lòng tạo ID khác!", "Thông báo");
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Thông báo");

            }    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

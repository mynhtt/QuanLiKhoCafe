using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafe
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text != "" && txbPassword.Text != "")
            {
                if (txbUserName.Text == "admin" && txbPassword.Text == "Admin1234")
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Close();
                    Form fMain = new frmMain();
                    fMain.Activate();
                    new frmProducts().Activate();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK);
                    txbPassword.Text = "";
                    txbUserName.Text = "";
                    txbUserName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập!", "Thông báo");
                txbPassword.Text = "";
                txbUserName.Text = "";
                txbUserName.Focus();
            }
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnLogin_Click(sender, e);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}

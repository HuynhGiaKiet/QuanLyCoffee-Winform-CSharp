using QuanLyCaPhe.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class frLogin : Form
    {
        static int count = 0;
        public bool kt;
        DangNhapBLL bll = new DangNhapBLL();
        public frLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            kt = false;
            if (bll.KiemTra(txt_username.Text.Trim(), txt_password.Text.Trim()))
            {
                kt = true;
                MessageBox.Show("Đăng Nhập Thành Công");

                {

                    this.Hide();
                    frMain frMain = new frMain();
                    frMain.Show();

                }

            }
            else
            {
                MessageBox.Show("sai tài khoản hoặc mật khẩu");
                count = count + 1;
                if (count >= 3)
                {
                    btn_login.Enabled = false;
                    MessageBox.Show("không được nhập quá 3 lần");

                }

            }
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void menu_ql_nhanvien_Click(object sender, EventArgs e)
        {
            fr_ql_nhanvien ql_Nhanvien = new fr_ql_nhanvien();
            ql_Nhanvien.Show();
        }

        private void menu_ql_sanpham_Click(object sender, EventArgs e)
        {
            fr_ql_sanpham _Sanpham = new fr_ql_sanpham();
            _Sanpham.Show();

        }

        private void menu_ql_xuathang_Click(object sender, EventArgs e)
        {
            fr_ql_phieuxuat phieuxuat = new fr_ql_phieuxuat();
            phieuxuat.Show();
        }

        private void menu_help_Click(object sender, EventArgs e)
        {
            fr_trogiup fr_Trogiup = new fr_trogiup();
            fr_Trogiup.Show();
        }

        private void menu_tk_sp_Click(object sender, EventArgs e)
        {
            fr_thongke_sanpham fr_Thongke_Sanpham = new fr_thongke_sanpham();
            fr_Thongke_Sanpham.Show();
        }

        private void menu_tk_phieuxuat_Click(object sender, EventArgs e)
        {
            fr_thongke_phieuxuat fr = new fr_thongke_phieuxuat();
            fr.Show();
        }

        private void menu_ql_nhaphang_Click(object sender, EventArgs e)
        {
            fr_phieunhap fr_Phieunhap = new fr_phieunhap();
            fr_Phieunhap.Show();
        }

        private void menu_tk_nhaphang_Click(object sender, EventArgs e)
        {
            fr_thongke_phieunhap fr = new fr_thongke_phieunhap();
            fr.Show();
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            frLogin login = new frLogin();
            login.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyCaPhe.Business;

namespace QuanLyCaPhe
{
    public partial class fr_thongke_sanpham : Form
    {
        public fr_thongke_sanpham()
        {
            InitializeComponent();
        }

        ChiTietPhieuXuatBLL ctpxbll = new ChiTietPhieuXuatBLL();
        private void tsThoat_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }
       

        private void tsThongKe_Click(object sender, EventArgs e)
        {
            if (cbKieuThongKe.Text == "Thống kê sản phẩm bán chạy")
            {
                dgThongKesp.DataSource = ctpxbll.ThongKeSanPhamBanChay();

            }

            else if (cbKieuThongKe.Text == "Thống kê sản phẩm bán chậm")
            {
                dgThongKesp.DataSource = ctpxbll.ThongKeSanPhamBanCham();

            }

            else
                MessageBox.Show("Bạn phải nhập kiêu thống kê");

        }

        private void tsLamMoi_Click(object sender, EventArgs e)
        {
            cbKieuThongKe.Text = "";
        }

        private void fr_thongke_sanpham_Load(object sender, EventArgs e)
        {
            dgThongKesp.DataSource = ctpxbll.Loadctpx();
        }
    }
}

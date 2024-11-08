using QuanLyCaPhe.Business;
using QuanLyCaPhe.DataAccess;
using QuanLyCaPhe.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class fr_thongke_phieunhap : Form
    {
        PhieuNhapBLL phieuNhapBLL = new PhieuNhapBLL();
        PhieuNhapDAL nhapDAL = new PhieuNhapDAL();
        PhieuNhap phieuNhap = new PhieuNhap();
        ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
        SanPhamBLL sanPham = new SanPhamBLL();
        NhanVienBLL nvnll = new NhanVienBLL();
        DataAccessHelper dataAccessHelper = new DataAccessHelper();

        double sum = 0;
        public fr_thongke_phieunhap()
        {
            InitializeComponent();
        }

        private void fr_thongke_phieunhap_Load(object sender, EventArgs e)
        {
            //pn.Mapn, pn.Manvnhap, nv.Tennv, pn.Ngaynhap, pn.Tennguoigiaohang, sp.Masp, sp.Tensp, sp.Dongia, ctpn.Soluong, ctpn.Thanhtien
            dgPhieuNhap.DataSource = phieuNhapBLL.loadData();
            dgPhieuNhap.Columns[0].HeaderText = "Mã phiếu nhập";
            dgPhieuNhap.Columns[1].HeaderText = "Mã nhân viên";
            dgPhieuNhap.Columns[2].HeaderText = "Mã tên nhân viên";
            dgPhieuNhap.Columns[3].HeaderText = "Ngày nhập";
            dgPhieuNhap.Columns[4].HeaderText = "Tên người giao hàng";
            dgPhieuNhap.Columns[5].HeaderText = "Mã sản phẩm";
            dgPhieuNhap.Columns[6].HeaderText = "Tên sản phẩm";
            dgPhieuNhap.Columns[7].HeaderText = "Đơn giá";
            dgPhieuNhap.Columns[8].HeaderText = "Số lượng";
            dgPhieuNhap.Columns[9].HeaderText = "Thành tiền";
            dgPhieuNhap.Columns[10].HeaderText = "Ghi chú";
            dgPhieuNhap.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgPhieuNhap.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void cbKieuThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
           sum = 0;
            switch (cbKieuThongKe.Text.ToString())
            {
                case "Thống kê ngày ":
                    dtpTuNgay.Value = DateTime.Parse(dt.ToShortDateString());
                    dtpDenNgay.Value = DateTime.Parse(dt.ToShortDateString());
                    break;
                case "Theo tháng":
                    dtpTuNgay.Value = DateTime.Parse(String.Format("{0}/1/{1}", dt.Month, dt.Year));
                    dtpDenNgay.Value = DateTime.Parse(String.Format("{0}/1/{1}", dt.Month + 1, dt.Year));
                    break;
                case "Theo năm":
                    dtpTuNgay.Value = DateTime.Parse(String.Format("1/1/{0}", dt.Year));
                    dtpDenNgay.Value = DateTime.Parse(String.Format("1/1/{0}", dt.Year + 1));
                    break;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        public double TongTien(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + double.Parse(dt.Rows[i][9].ToString());
            }
            return sum;
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            DataTable dt = nhapDAL.thongKePN(dtpTuNgay.Value.ToShortDateString(), dtpDenNgay.Value.ToShortDateString());

            {
                dgPhieuNhap.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    txtTongTien.Text = TongTien(dt).ToString();
                }
                else
                {
                    txtTongTien.Text = "";
                }
            }
        }
    }
}

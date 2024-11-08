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
    public partial class fr_chitietphieuxuat : Form
    {
        public fr_chitietphieuxuat()
        {
            InitializeComponent();
        }

        ChiTietPhieuXuatBLL bll = new ChiTietPhieuXuatBLL();
        SanPhamBLL dtb = new SanPhamBLL();
        PhieuXuatBLL pxb = new PhieuXuatBLL();
        DataTable dt = new DataTable();
        // xây dựng phương thức tính tổng tiền
        double Tong = 0;
        public double TongTien(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Tong = Tong + double.Parse(dt.Rows[i][3].ToString());
            }
            return Tong;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                //Kiểm tra sự hợp lệ của chi tiết phiếu xuất
                if (bll.tongbanghi(cbMaPhieuXuat.Text, cbMaSanPham.Text) == 1)
                    MessageBox.Show("Chi tiết phiếu xuất này không hợp lệ. Nhập chi tiết phiếu xuất khác!");
                else if (bll.tongbanghi(cbMaPhieuXuat.Text, cbMaSanPham.Text) == 0)
                {
                    if (txtSoLuong.Text != "" && txtDonGia.Text != "")
                    {
                        tinhtien();
                        MessageBox.Show("Số tiền khách hàng phải trả cho sản phẩm này là:" + txtThanhTien.Text + "");
                    }

                    bll.Thempx(cbMaPhieuXuat.Text, cbMaSanPham.Text, int.Parse(txtSoLuong.Text), double.Parse(txtThanhTien.Text));
                    fr_chitietphieuxuat_Load(sender, e);

                }
            }
            btn_add.Enabled = true;
            if (btn_edit.Enabled == false)
            {
                bll.update(cbMaPhieuXuat.Text, cbMaSanPham.Text, int.Parse(txtSoLuong.Text), double.Parse(txtThanhTien.Text));
                fr_chitietphieuxuat_Load(sender, e);
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }

        private void cbMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtb.laygiaban(cbMaSanPham.Text);
           
            {
                txtDonGia.Text = cbMaSanPham.SelectedValue.ToString();

            }
        }

        private void btn_seacrh_Click(object sender, EventArgs e)
        {
            DataTable dt = null;

            if (cbTimKiem.Text== "Tìm kiếm theo mã phiếu")
            {
               dt = bll.Listctpx(cbMaPhieuXuat.Text);
            }
           
                dgChiTietPhieuXuat.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    txtTongtien.Text = TongTien(dt).ToString();

                }
                else
                {
                    txtTongtien.Text = "";
                }
            
            cbTimKiem.Text = "";
        }

        private void fr_chitietphieuxuat_Load(object sender, EventArgs e)
        {
            dgChiTietPhieuXuat.DataSource = bll.Loadctpx();

            // load mã sản phẩm
            SanPhamBLL dtb = new SanPhamBLL();
            cbMaSanPham.DataSource = dtb.LoadSP();
            cbMaSanPham.DisplayMember = "masp";
            cbMaSanPham.ValueMember = "dongia";
            cbMaSanPham.SelectedIndex = 1;

            //load ma phieu xuat
            PhieuXuatBLL pxb = new PhieuXuatBLL();
            cbMaPhieuXuat.DataSource = pxb.LoadPX();
            cbMaPhieuXuat.DisplayMember = "mapx";
            //load ma phieu xuat vao ô tìm kiếm
            
            dgChiTietPhieuXuat.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgChiTietPhieuXuat.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgChiTietPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            cbMaPhieuXuat.Text = dgChiTietPhieuXuat[0, hang].Value.ToString();
            cbMaSanPham.Text = dgChiTietPhieuXuat[1, hang].Value.ToString();
            txtSoLuong.Text = dgChiTietPhieuXuat[2, hang].Value.ToString();
            txtThanhTien.Text = dgChiTietPhieuXuat[3, hang].Value.ToString();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chi tiết phiếu xuất này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.XoaChiTietPhieuXuat(cbMaPhieuXuat.Text, cbMaSanPham.Text, int.Parse(txtSoLuong.Text), double.Parse(txtThanhTien.Text));


                MessageBox.Show("Xóa thành công");
                fr_chitietphieuxuat_Load(sender, e);

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            cbMaSanPham.Text = "";
            cbMaPhieuXuat.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "";
            txtTongtien.Text = "";
            btn_add.Enabled = false;
            cbMaSanPham.Enabled = true;
            cbMaPhieuXuat.Enabled = true;
            btn_edit.Enabled = false;
            
        }

        public void tinhtien()
        {
            int soluong;
            double dongia, thanhtien;
            if (txtSoLuong.Text == "")
            { MessageBox.Show("chua nhap so luong"); }
            else
            {
                soluong = int.Parse(txtSoLuong.Text);
                dongia = double.Parse(txtDonGia.Text);

                if (soluong <= 0)
                {
                    MessageBox.Show("so luong phai >0");
                }
                else
                {
                    thanhtien = soluong * dongia;
                    txtThanhTien.Text = thanhtien.ToString();

                }

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

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            tinhtien();
        }
    }
}

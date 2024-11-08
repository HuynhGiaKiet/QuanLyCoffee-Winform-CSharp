using QuanLyCaPhe.Business;
using QuanLyCaPhe.DataAccess;
using QuanLyCaPhe.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class fr_phieunhap : Form
    {
        PhieuNhapBLL phieuNhapBLL = new PhieuNhapBLL();
        PhieuNhap phieuNhap = new PhieuNhap();
        ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
        SanPhamBLL sanPham = new SanPhamBLL();
        NhanVienBLL nvnll = new NhanVienBLL();
        DataAccessHelper dataAccessHelper = new DataAccessHelper();

        public fr_phieunhap()
        {
            InitializeComponent();
        }

        private void fr_phieunhap_Load(object sender, EventArgs e)
        {
            
            
            cbManv.DataSource = nvnll.LoadNV();
            cbManv.DisplayMember = "manv";
            cbtenNV.DataSource = nvnll.LoadNV();
            cbtenNV.DisplayMember = "tennv";
           
            cbMaSp.DataSource = sanPham.LoadSP();
            cbMaSp.DisplayMember = "masp";

            cbtensp.DataSource = sanPham.LoadSP();
            cbtensp.DisplayMember = "tensp";

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

        private void btn_add_Click(object sender, EventArgs e)
        {
            txtMapn.Text = "";
            cbMaSp.Text = "";
            cbManv.Text = "";
            txt_slg.Text = ""; 
            txt_don_gia.Text = "";
            cbMaSp.Enabled = true;
            txtMapn.Enabled = true;
            btn_add.Enabled = false;
            btn_edit.Enabled = true;
        }

        private void cbManv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select tennv from nhanvien where manv= N'" + cbManv.Text.Trim() + "'";
            cbtenNV.Text = dataAccessHelper.GetFieldValues(sql);
        }

        private void cbMaSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select tensp from sanpham where masp= N'" + cbMaSp.Text.Trim() + "'";
            cbtensp.Text = dataAccessHelper.GetFieldValues(sql);
            string sql1 = "select dongia from sanpham where masp= N'" + cbMaSp.Text.Trim() + "'";
           txt_don_gia.Text = dataAccessHelper.GetFieldValues(sql1);
        }

        private void txt_slg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
           
        }

        private void txt_slg_KeyUp(object sender, KeyEventArgs e)
        {
            double thanhtien = 0;
            int soluong = 0;
            if (txt_slg.Text.Trim() == "")
            {
                soluong = 0;
            }
            else
            {
                soluong = int.Parse(txt_slg.Text);
            }
            try
            {
                thanhtien = int.Parse(txt_don_gia.Text) * soluong;
                txt_thanhtien.Text = thanhtien.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phiếu nhập này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string a = txtMapn.Text.Trim();
                phieuNhapBLL.deteleDataCTPN(txtMapn.Text.Trim(), cbMaSp.Text.Trim());
                try
                {
                    phieuNhapBLL.deteleDataPN(txtMapn.Text.Trim());
                }catch(SqlException)
                {

                }
               
                MessageBox.Show("Xóa thành công");
                fr_phieunhap_Load(sender, e);
                
            }
        }

        private void dgPhieuNhap_Click(object sender, EventArgs e)
        {
            //pn.Mapn, pn.Manvnhap, nv.Tennv, pn.Ngaynhap, pn.Tennguoigiaohang, sp.Masp, sp.Tensp, sp.Dongia, ctpn.Soluong, ctpn.Thanhtien
            txtMapn.Text = dgPhieuNhap.CurrentRow.Cells["mapn"].Value.ToString();
            cbManv.Text = dgPhieuNhap.CurrentRow.Cells["manvnhap"].Value.ToString();
           cbtenNV.Text = dgPhieuNhap.CurrentRow.Cells["Tennv"].Value.ToString();
           ngaynhap.Text = dgPhieuNhap.CurrentRow.Cells["Ngaynhap"].Value.ToString();
            nguoigiaohang.Text = dgPhieuNhap.CurrentRow.Cells["Tennguoigiaohang"].Value.ToString();
            cbMaSp.Text = dgPhieuNhap.CurrentRow.Cells["Masp"].Value.ToString();
            txt_don_gia.Text = dgPhieuNhap.CurrentRow.Cells["Dongia"].Value.ToString();
            txt_slg.Text = dgPhieuNhap.CurrentRow.Cells["Soluong"].Value.ToString();
            txt_thanhtien.Text = dgPhieuNhap.CurrentRow.Cells["ThanhTien"].Value.ToString();
            txt_ghichu.Text = dgPhieuNhap.CurrentRow.Cells["GhiChu"].Value.ToString();
         
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txtMapn.Enabled = false;
            btn_edit.Enabled = false;
            btn_add.Enabled = true;
            cbMaSp.Enabled = false;
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                DateTime ngaynhapDH = ngaynhap.Value;
                if (txtMapn.Text.Trim() == "" || cbMaSp.Text.Trim() == "" || cbManv.Text.Trim() == "" || txt_slg.Text.Trim() == "" || txt_don_gia.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin");
                    return;
                }
                if ((int.TryParse(txt_don_gia.Text.Trim(), out int x) == false) || (int.TryParse(txt_slg.Text.Trim(), out int a) == false))
                {
                    MessageBox.Show("Không đúng định dạng số");
                    return;
                }
                if (phieuNhapBLL.TongBanGhiPN(txtMapn.Text.Trim()) < 1)
                {
                    phieuNhapBLL.insertDataPN(txtMapn.Text.Trim(), cbManv.Text.Trim(), ngaynhapDH, nguoigiaohang.Text.Trim(), txt_ghichu.Text.Trim());

                }
                else if (phieuNhapBLL.TongBanGhiPN(txtMapn.Text.Trim()) >= 1)
                {
                    MessageBox.Show("Thông báo lỗi", "Đơn hàng này đã tồn tại", MessageBoxButtons.OK);
                }

                if (phieuNhapBLL.TongBanGhiCTPN(txtMapn.Text.Trim(), cbMaSp.Text.Trim()) < 1)
                {

                    phieuNhapBLL.insertDataCTPN(txtMapn.Text.Trim(), cbMaSp.Text.Trim(), int.Parse(txt_slg.Text), double.Parse(txt_thanhtien.Text));

                    MessageBox.Show("Thông báo thành công", "Thêm đơn hàng thành công", MessageBoxButtons.OK);

                }
                else if (phieuNhapBLL.TongBanGhiCTPN(txtMapn.Text.Trim(), cbMaSp.Text.Trim()) > 1)
                {
                    MessageBox.Show("Thông báo lỗi", "Đơn hàng này đã tồn tại", MessageBoxButtons.OKCancel);
                }

                fr_phieunhap_Load(sender, e);
            }
            btn_add.Enabled = true;
            if(btn_edit.Enabled == false)
            {
                phieuNhapBLL.updateDataPN(txtMapn.Text.Trim(), cbManv.Text.Trim(), ngaynhap.Value, nguoigiaohang.Text.Trim(), txt_ghichu.Text.Trim());
                phieuNhapBLL.updateDataCTPN(txtMapn.Text.Trim(), cbMaSp.Text.Trim(), int.Parse(txt_slg.Text), double.Parse(txt_thanhtien.Text));

                MessageBox.Show("Cập nhật thành công", "Thông báo");
                fr_phieunhap_Load(sender, e);
            }
        }

        private void btn_seacrh_Click(object sender, EventArgs e)
        {
            if (cb_timkiem.Text == "Theo mã phiếu nhập")
            {
                string sql = "select pn.Mapn, pn.Manvnhap, nv.Tennv, pn.Ngaynhap, pn.Tennguoigiaohang, sp.Masp, sp.Tensp, sp.Dongia, ctpn.Soluong, ctpn.Thanhtien, pn.ghichu" +
                " from PhieuNhap pn join ChiTietPhieuNhap ctpn on ctpn.Mapn = pn.Mapn join SanPham sp on sp.Masp = ctpn.Masp join NhanVien nv on nv.Manv = pn.Manvnhap where pn.Mapn=N'" + txtMapn.Text.Trim()+"'";

                if (txtMapn.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã phiếu nhập","Thông báo");
                    txtMapn.Focus();
                    return;
                }
                dgPhieuNhap.DataSource = dataAccessHelper.get_DaTaTable(sql);
            }
            else if (cb_timkiem.Text == "Theo mã sản phẩm")
            {
                string sql = "select pn.Mapn, pn.Manvnhap, nv.Tennv, pn.Ngaynhap, pn.Tennguoigiaohang, sp.Masp, sp.Tensp, sp.Dongia, ctpn.Soluong, ctpn.Thanhtien, pn.ghichu" +
                " from PhieuNhap pn join ChiTietPhieuNhap ctpn on ctpn.Mapn = pn.Mapn join SanPham sp on sp.Masp = ctpn.Masp join NhanVien nv on nv.Manv = pn.Manvnhap where pn.Mapn=N'" + cbMaSp.Text.Trim() + "'";

                if (cbMaSp.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã phiếu nhập", "Thông báo");
                    cbMaSp.Focus();
                    return;
                }
                dgPhieuNhap.DataSource = dataAccessHelper.get_DaTaTable(sql);
            }
            else if (cb_timkiem.Text == "Theo tên nhân viên nhập hàng")
            {
                string sql = "select pn.Mapn, pn.Manvnhap, nv.Tennv, pn.Ngaynhap, pn.Tennguoigiaohang, sp.Masp, sp.Tensp, sp.Dongia, ctpn.Soluong, ctpn.Thanhtien, pn.ghichu" +
               " from PhieuNhap pn join ChiTietPhieuNhap ctpn on ctpn.Mapn = pn.Mapn join SanPham sp on sp.Masp = ctpn.Masp join NhanVien nv on nv.Manv = pn.Manvnhap where Tennv Like N'%" + cbtenNV.Text.Trim() + "%'";

                if (cbtenNV.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã phiếu nhập", "Thông báo");
                    cbMaSp.Focus();
                    return;
                }
                dgPhieuNhap.DataSource = dataAccessHelper.get_DaTaTable(sql);
            }
        }
    }
}

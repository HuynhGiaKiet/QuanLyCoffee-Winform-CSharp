using QuanLyCaPhe.Business;
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
    public partial class fr_ql_phieuxuat : Form
    {
        public fr_ql_phieuxuat()
        {
            InitializeComponent();
        }
        PhieuXuat px = new PhieuXuat();
        PhieuXuatBLL pxb = new PhieuXuatBLL();
        SanPhamBLL dtb = new SanPhamBLL();
        ChiTietPhieuXuatBLL ctx = new ChiTietPhieuXuatBLL();
        DataTable dt = new DataTable();
        private void fr_ql_phieuxuat_Load(object sender, EventArgs e)
        {
            // load các phiếu xuất đã có
            dgPhieuXuat.DataSource = pxb.LoadPX();
            //load ma nhan vien
            NhanVienBLL nvnll = new NhanVienBLL();
            cbManv.DataSource = nvnll.LoadNV();
            cbManv.DisplayMember = "manv";
            dgPhieuXuat.Columns[0].HeaderText = "Mã phiếu";
            dgPhieuXuat.Columns[1].HeaderText = "Mã nhân viên";
            dgPhieuXuat.Columns[2].HeaderText = "Ngày xuất";
            dgPhieuXuat.Columns[3].HeaderText = "Bàn số";
            dgPhieuXuat.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgPhieuXuat.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_edit.Enabled = true;

            txtMapx.Text = "";
            cbBanSo.Text = "";
            cbManv.Text = "";
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (btn_add.Enabled == false)
            {
                try
                {
                    //Kiểm tra mã có trùng hay không?
                    if (pxb.tongbanghi(txtMapx.Text) == 1)
                        MessageBox.Show("Mã: " + txtMapx.Text + " đã tồn tại. Nhập mã khác!");
                    else if (pxb.tongbanghi(txtMapx.Text) == 0)
                    {
                        string a = ngayxuat.Value.ToString();
                        if (txtMapx.Text != "" && cbManv.Text != "" && cbBanSo.Text != "")
                        {
                            pxb.Thempx(txtMapx.Text, cbManv.Text, int.Parse(cbBanSo.Text));
                            MessageBox.Show("Thêm thành công");
                            fr_ql_phieuxuat_Load(sender, e);
                        }


                    }
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại", "thông báo", MessageBoxButtons.OK);
                }
            }
            btn_add.Enabled = true;
            if (btn_edit.Enabled == false)
            {
                  btn_add.Enabled = false;
            btn_edit.Enabled = true; pxb.updateDaTaPN(txtMapx.Text.Trim(), cbManv.Text.Trim(), ngayxuat.Value, int.Parse(cbBanSo.Text));
                MessageBox.Show("Sửa thành công", "Thông báo");
                fr_ql_phieuxuat_Load(sender, e);
            }
        }

        private void dgPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phiếu xuất này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pxb.Xoapx(txtMapx.Text, cbManv.Text, int.Parse(cbBanSo.Text));
                MessageBox.Show("Xóa thành công");
               fr_ql_phieuxuat_Load(sender, e);
            }
        }

        private void btn_seacrh_Click(object sender, EventArgs e)
        {
            dgPhieuXuat.DataSource = pxb.Listpx(txtMapx.Text);
            txtMapx.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fr_chitietphieuxuat fr_Chitietphieuxuat = new fr_chitietphieuxuat();
            fr_Chitietphieuxuat.Show();
        }

        private void dgPhieuXuat_Click(object sender, EventArgs e)
        {
          
            txtMapx.Text = dgPhieuXuat.CurrentRow.Cells["mapx"].Value.ToString();
            cbManv.Text = dgPhieuXuat.CurrentRow.Cells["Manvxuat"].Value.ToString();
            ngayxuat.Value = (DateTime) dgPhieuXuat.CurrentRow.Cells["ngayxuat"].Value;
            cbBanSo.Text = dgPhieuXuat.CurrentRow.Cells["banso"].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
        }
    }
}
